using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsS : MonoBehaviour
{
    private Rigidbody r;
    private int k = 0;

    private int x1 = 48, x2 = 45, z1 = 47, z2 = 45;
    public AudioClip CoinCollisionSound;
    public AudioSource CollisionSoundSource;

    // Start is called before the first frame update
    void Start()
    {
        CollisionSoundSource.clip = CoinCollisionSound;
    }

    // Update is called once per frame
    void Update()
    {
        r = GetComponent<Rigidbody>();
        Vector3 v = new Vector3();
        v = r.position;
        string Tag = r.gameObject.tag;

        if (k != MainPoints.flag && MainPoints.QueenFlag != 0 && Tag == "Queen")
        {
            r.transform.position = new Vector3(0, 3, 0);
            k = 0;
            MainPoints.QueenFlag = 0;
        }


        //Top Right Hole
        if (v.x < x1 && v.x > x2 && v.z < z1 && v.z > z2)
        {
            PointLogic();
        }

        //Top Left Hole, WORKING
        if (v.x > -x1 && v.x < -x2 && v.z < z1 && v.z > z2)
        {
            PointLogic();
        }

        //Bottom Right Hole
        if (v.x < x1 && v.x > x2 && v.z > -z1 && v.z < -z2)
        {
            PointLogic();
        }

        //Bottom Left Hole
        if (v.x > -x1 && v.x < -x2 && v.z > -z1 && v.z < -z2)

        {
            PointLogic();
        }

    }

    private void PointLogic()
    {
        CollisionSoundSource.Play();
        r = GetComponent<Rigidbody>();
        Vector3 v = new Vector3();
        v = r.position;
        string Tag = r.gameObject.tag;

        r.velocity = new Vector3(0, 0, 0);
        r.transform.eulerAngles = new Vector3(0, 0, 0);
        if (Tag == "White")
        {
            if (MainPoints.QueenFlag == -1)
            {
                MainPoints.QueenFlag = 0;
                MainPoints.WhiteScore++;
            }

            if (MainPoints.WhiteStrikerFlag == 0)
            {
                r.gameObject.tag = "WhiteHoled";
                r.transform.position = new Vector3(-44, 25, 54);
            }
            else if (MainPoints.WhiteStrikerFlag > 0)
            {
                r.transform.position = new Vector3(0.0f, 0.7500058f, 0.0f);
                MainPoints.WhiteStrikerFlag--;
            }

            MainPoints.WhiteScore++;

        }

        else if (Tag == "Black")
        {
            if (MainPoints.QueenFlag == 1)
            {
                MainPoints.QueenFlag = 0;
                MainPoints.BlackScore++;
            }

            if (MainPoints.BlackStrikerFlag == 0)
            {
                r.gameObject.tag = "BlackHoled";
                r.transform.position = new Vector3(44, 25, 54);

            }
            else if (MainPoints.BlackStrikerFlag > 0)
            {
                r.transform.position = new Vector3(0.0f, 0.7500058f, 0.0f);
                MainPoints.BlackStrikerFlag--;
            }
            MainPoints.BlackScore++;

        }

        else if (Tag == "Striker")
        {

            r.transform.position = new Vector3(0, 12, 54);
            if (MainPoints.flag > 0)
            {
                MainPoints.WhiteScore--;
                MainPoints.WhiteStrikerFlag++;
            }
            else
            {
                MainPoints.BlackScore--;
                MainPoints.BlackStrikerFlag++;
            }

        }

        else if (Tag == "Queen")
        {
            if (MainPoints.flag > 0)
            {
                r.transform.position = new Vector3(-23, 12, 53);
                MainPoints.QueenFlag = -1;
                k = MainPoints.flag;
            }

            else
            {
                r.transform.position = new Vector3(23, 12, 53);
                MainPoints.QueenFlag = 1;
                k = MainPoints.flag;
            }

        }

        else if (Tag == "WhiteHoled")
        {
            r.transform.position = new Vector3(-44, 25, 54);
        }

        else if (Tag == "BlackHoled")
        {
            r.transform.position = new Vector3(44, 25, 54);
        }
    }
}
