using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float _rotation;

    private void Update()
    {
        gameObject.transform.rotation = Quaternion.Euler(0,0,_rotation);
        _rotation ++;
    }
}
