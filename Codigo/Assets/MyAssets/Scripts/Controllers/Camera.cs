using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float smoothSpeed = 0.7f;
    private void FixedUpdate()
    {
        if(NinjaController.ninja!=null)
        {
            Vector3 desiredPosition= NinjaController.ninja.CameraFollower();
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
           
    }
}
