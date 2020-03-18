using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotations : MonoBehaviour
{
    public float _speed;

    void Update()
    {
        transform.Rotate(0, _speed,0,Space.World);

    }
    
}
