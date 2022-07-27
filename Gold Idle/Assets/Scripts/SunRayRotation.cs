using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRayRotation : MonoBehaviour
{
    [Range(0f,1f)] public float smooth = 1f;


    void FixedUpdate() 
    {
        this.transform.Rotate(Vector3.forward * smooth);
    }
}
