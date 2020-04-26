using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionAiming : MonoBehaviour
{
    private Rigidbody r;
    int TurnFlag = 1;
    public float x = 0.0f;
    public Button strikeButton;
    private float z = -33.5f;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();

        Button strike = strikeButton.GetComponent<Button>();
        strike.onClick.AddListener(OnClicking);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClicking()
    {
        r.transform.position = new Vector3(x, 0.7500015f, z);

    }

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

    //For next turn
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
