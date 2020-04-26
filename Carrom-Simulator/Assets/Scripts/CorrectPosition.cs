using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectPosition : MonoBehaviour
{
    private string Tag;
    private Rigidbody r;
    void Start()
    {
        

    }

    // Update is called once per frame
    private void Update()
    {
        r = GetComponent<Rigidbody>();
        Vector3 v = new Vector3();
        v = r.position;
        Tag = r.gameObject.tag;

        if (Tag == "White" || Tag == "Black" || Tag == "Queen")
        {
            if (v.x < -48 || v.x > 48 || v.z < -48 || v.z > 48 || v.y < -10 || v.y > 30)
            {
                r.transform.position = new Vector3(0.0f, 5.0f, 0.0f);
                r.velocity = new Vector3(0.0f, 0.0f, 0.0f);

            }
        }

        else if (Tag == "Striker")
        {
            if (v.x < -60 || v.x > 60 || v.z < -60 || v.z > 60 || v.y < -10 || v.y > 30)
            {
                r.transform.position = new Vector3(0, 12, 54);
                r.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            }
        }

        else if (Tag == "WhiteHoled")
        {
            if (v.y < 7 || v.y > 30)
            {
                r.transform.position = new Vector3(-44, 25, 54);
                r.velocity = new Vector3(0.0f, 0.0f, 0.0f);
                r.transform.eulerAngles = new Vector3(0, 0, 0);
            }
        }

        else if (Tag == "BlackHoled")
        {
            if (v.y < 7 || v.y > 30)
            {
                r.transform.position = new Vector3(44, 25, 54);
                r.velocity = new Vector3(0.0f, 0.0f, 0.0f);
                r.transform.eulerAngles = new Vector3(0, 0, 0);
            }
        }

        else if (Tag == "QueenHoled")
        {
            if (v.y < 7 || v.y > 30)
            {
                if (MainPoints.MainPointQueenFlag == -1)
                {
                    r.transform.position = new Vector3(23, 12, 53);
                    r.velocity = new Vector3(0.0f, 0.0f, 0.0f);
                    r.transform.eulerAngles = new Vector3(0, 0, 0);
                }

                if (MainPoints.MainPointQueenFlag == 1)
                {
                    r.transform.position = new Vector3(-23, 12, 53);
                    r.velocity = new Vector3(0.0f, 0.0f, 0.0f);
                    r.transform.eulerAngles = new Vector3(0, 0, 0);
                }

                if (MainPoints.QueenFlag != 0)
                {
                    r.transform.position = new Vector3(23, 12, 53);
                    r.velocity = new Vector3(0.0f, 0.0f, 0.0f);
                    r.transform.eulerAngles = new Vector3(0, 0, 0);
                }
            }
        }
    }
}
