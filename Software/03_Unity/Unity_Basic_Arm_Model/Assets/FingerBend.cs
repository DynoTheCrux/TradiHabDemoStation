using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerBend : MonoBehaviour
{
    public Transform carpalThumb;
    public Transform carpalIndex;
    public Transform carpalMiddle;
    public Transform carpalRing;
    public Transform carpalPinky;

    public float angle;

    // Start is called before the first frame update
    void Start()
    {
        /*
        foreach (Transform child in carpalIndex)
            child.Rotate(0, 0, angle);

        foreach (Transform child in carpalMiddle)
            child.Rotate(0, 0, angle);

        foreach (Transform child in carpalRing)
            child.Rotate(0, 0, angle);

        foreach (Transform child in carpalPinky)
            child.Rotate(0, 0, angle);
         */
    }

    // Update is called once per frame
    void Update()
    {
            
    }
}
