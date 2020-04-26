using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhyiscsSliders : MonoBehaviour
{
    public PhysicMaterial material;

    float NewBounciness = 0.175f;
    float Friction = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        material.bounciness = NewBounciness;
        material.dynamicFriction = Friction;
        material.staticFriction = Friction;
    }

    public void ChangeBounciness(float NewBoun)
    {
        NewBounciness = NewBoun;
    }

    public void ChangeFriction(float NewFric)
    {
        Friction = NewFric;
    }
}
