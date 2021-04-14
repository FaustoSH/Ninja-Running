using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecureLocation : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(NinjaController.ninja!=null)
        {
            NinjaController.ninja.secureLocation = gameObject.transform.position;
        }
    }
}
