using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LianaController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Ninja" && !NinjaController.ninja.liana)
        {
            gameObject.transform.GetChild(2).transform.position = collision.transform.position;
            NinjaController.ninja.GetComponent<Rigidbody2D>().gravityScale = 0;
            NinjaController.ninja.PointOfCollision = gameObject.transform.GetChild(2);
            NinjaController.ninja.canJump = true;
            NinjaController.ninja.stopped = true;
            NinjaController.ninja.liana = true;
            NinjaController.ninja.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
