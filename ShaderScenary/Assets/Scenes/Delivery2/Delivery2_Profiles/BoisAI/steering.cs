using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steering 
{
    public float angular; //Rotation 0->360
    public Vector3 linear;

    public steering()
    {
        angular = 0.0f;
        linear = new Vector3();
    }
}
