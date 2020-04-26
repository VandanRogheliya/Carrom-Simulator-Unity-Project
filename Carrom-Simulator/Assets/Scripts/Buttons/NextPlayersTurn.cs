using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPlayersTurn : MonoBehaviour
{
    private Rigidbody r;
    private float z = -38.1f;
    void Start()
    {
        newPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void newPosition()
    {
        r = GetComponent<Rigidbody>();
        z *= -1;
        r.transform.position = new Vector3(0.0f, 0.7500015f, z);
    }
}
