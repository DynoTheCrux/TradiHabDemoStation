using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class Key_Rotator : MonoBehaviour
{
    public Transform handTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 angles = handTarget.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(-angles.z + 180, 90, -angles.x);
    }
}
