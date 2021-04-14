using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NinjaController : MonoBehaviour
{
    public static NinjaController ninja;
    public bool canJump = true, dead = false, stopped = false, liana = false;
    public int points, mapPoints;
    private bool afterJump = false;
    private float prevJumpY, inGround;
    public Vector3 secureLocation;
    public Transform PointOfCollision = null;
    void Start()
    {
        mapPoints =0;
        points = 0;
        prevJumpY = -99999999;
        ninja = this;
    }
    // Update is called once per frame
    void Update()
    {
        if (afterJump)
        {
            if ((transform.position.y - prevJumpY) > 0.185f || prevJumpY == inGround) //Stops "going forward force" until reaches certain high
            {
                afterJump = false;
                stopped = false;
                prevJumpY = -999999999;
            }
        }
           
        if(!stopped)
        {
            gameObject.GetComponent<Animator>().SetBool("Stopped", false);
            gameObject.transform.Translate(1.5f * Time.deltaTime, 0, 0);
        }else 
        {
            gameObject.GetComponent<Animator>().SetBool("Stopped", true);
            if (liana)
                gameObject.transform.position = new Vector3(PointOfCollision.transform.position.x+0.2f, PointOfCollision.transform.position.y, PointOfCollision.transform.position.z);
        }
            
        Quaternion rotation = new Quaternion();
        gameObject.transform.rotation = rotation;
        
        if (canJump&&Input.GetKeyDown("up")) //Using this the bug doesn't show up
        {
            jump();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            //secureLocation = gameObject.transform.position;
            inGround = transform.position.y;
            canJump = true;
        }
        if(collision.transform.tag=="Wall")
        {
            //canJump = true;
            stopped = true;
        }
        if(collision.transform.tag=="Top")
        {
            canJump = false;
        }
        if (collision.transform.tag == "Lava")
        {
            dead = true;
        }
    }
    public void jump()
    {
        if (gameObject.GetComponent<Rigidbody2D>().velocity.y<0.5f||liana)
        {
            prevJumpY = transform.position.y;
            canJump = false;
            afterJump = true;
            if(liana)
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(100, 300));
                stopped = false;
                liana = false;
                prevJumpY = -999999999;
            }else
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 445));
        }
            
    }

    public Vector3 CameraFollower()
    {
        Vector3 pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -10);
        return pos;
    }
    public Vector3 whereIsPlayerFull()
    {
        
        return gameObject.transform.position;
    }
}
