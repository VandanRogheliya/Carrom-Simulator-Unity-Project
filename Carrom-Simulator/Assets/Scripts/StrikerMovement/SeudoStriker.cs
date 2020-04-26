using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeudoStriker : MonoBehaviour
{
    private Rigidbody r;

    public float x;
    private float z = -33.5f;
    int TurnFlag = 1;
    public float Yr = 1.57f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Y;
        Y = -1 * (Yr * 180 / 3.14f - 90);
        Vector3 v = new Vector3(0.0f, Y, 0.0f);
        r = GetComponent<Rigidbody>();
        r.transform.position = new Vector3(x, 0.7500015f, z);
        r.transform.eulerAngles = v;
    }
    //Attach to position slider
    public void NewX(float newX)
    {
        if (TurnFlag % 2 == 1)
        {
            x = newX;
        }

        else
        {
            z = newX;
        }
    }
    //Angle from angle slider
    public void NewYr(float newYr)
    {
        Yr = newYr;
    }

    //Attact to next plater button
    public void newPosition()
    {
        TurnFlag++;
        if (TurnFlag % 4 == 2)
        {
            x = 34;
            z = 0;
        }

        else if (TurnFlag % 4 == 3)
        {
            x = 0;
            z = 34;
        }

        else if (TurnFlag % 4 == 0)
        {
            x = -34;
            z = 0;
        }
        else if (TurnFlag % 4 == 1)
        {
            x = 0;
            z = -34;
        }



    }
}
