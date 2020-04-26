using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MovingStriker : MonoBehaviour
{
    public float forceMultipl = 1f;
    private Rigidbody r;
    public float angle = 1f;
    public Button strikeButton;

    private void Start()
    {
        r = GetComponent<Rigidbody>();

        Button strike = strikeButton.GetComponent<Button>();
        strike.onClick.AddListener(ChangeVelocity);
        
    }

    private void Update()
    {
        
    }
    //force from slider
    public void NewForce( float newForce)
    {
        forceMultipl = newForce;
    }

    //Angle from Slider
    public void NewAngle(float newAngle)
    {
        angle = newAngle;
    }
    //Stike force and angle
    void ChangeVelocity()
    {
        r.velocity = (transform.right * Mathf.Cos(angle) + transform.forward * Mathf.Sin(angle)) * Time.deltaTime * forceMultipl * 20000;
    }
    

}
