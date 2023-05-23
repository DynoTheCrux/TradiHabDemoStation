using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public SerialController serialController;
    public Transform rHandTarget;
    [Space(20)]
    public bool debugInfo = false;

    private const float steps = 2000.0f;
    private const float stepsToDegree = 360.0f / steps;
    private const float PS_gearRatio = 220.0f / 8.0f;
    //private float stepsToDegree = 360.0f / 4000.0f;

    private string serialData;
    private bool isConnected = false;

    public float anglePS = 0;

    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
        
    }

    // Executed each frame
    void Update()
    {
        string receivedMessage = handleSerialCom();

        if (!isConnected || receivedMessage == null) return;

        string[] values = receivedMessage.Split(' ');
        anglePS = ((float.Parse(values[0]) / PS_gearRatio) % steps) * stepsToDegree;

        //set rotation to device angle
        Vector3 temp = rHandTarget.rotation.eulerAngles;
        temp.z = -anglePS;
        rHandTarget.rotation = Quaternion.Euler(temp);
    }

    public string handleSerialCom()
    {
        //sendSerialData();

        string message = serialController.ReadSerialMessage();

        if (message == null)
            return null;

        // Check if the message is plain data or a connect/disconnect event.
        if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_CONNECTED))
        {
            if (debugInfo) Debug.Log("Connection established");
            isConnected = true;
            return null;
        }
        else if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_DISCONNECTED))
        {
            if (debugInfo)  Debug.Log("Connection attempt failed or disconnection detected");
            isConnected = false;
            return null;
        }
        else{
            if (debugInfo) Debug.Log("Message arrived: " + message);
            return message;
        }
            
    }

    public void sendSerialData()
    {
        //serialData = test.x + "," + test.y + "," + test.z;
        //serialController.SendSerialMessage(serialData);
        //serialData = "";
    }
}
