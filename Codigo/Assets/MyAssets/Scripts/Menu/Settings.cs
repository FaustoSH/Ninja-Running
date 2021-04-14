using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private Transform camara=null;
    private static bool showMenu = false;
    private void Update()
    {
        if (gameObject.name.Equals("Menu")||gameObject.name.Equals("MenuMuerte"))
            gameObject.transform.position = new Vector3(camara.position.x, camara.position.y, 0); //gameObject.transform.position = new Vector3(NinjaController.ninja.CameraFollower().x, NinjaController.ninja.CameraFollower().y, 0);
    }
    public void settings()
    {
        if(!showMenu)
        {
            Time.timeScale = 0;
            GameObject.Find("Sound").GetComponent<Button>().enabled = true;
            GameObject.Find("Button1").GetComponent<Button>().enabled = true;
            GameObject.Find("Button2").GetComponent<Button>().enabled = true;
            GameObject.Find("Menu").GetComponent<SpriteRenderer>().sortingLayerName = "Menu";
            GameObject.Find("CanvasMenu").GetComponent<Canvas>().sortingLayerName = "Menu";
            GameObject.Find("Menu").GetComponent<SpriteRenderer>().sortingOrder = 6;
            GameObject.Find("CanvasMenu").GetComponent<Canvas>().sortingOrder = 7;
            showMenu = true;
        }else
        {
            Time.timeScale = 1;
            GameObject.Find("Sound").GetComponent<Button>().enabled = false;
            GameObject.Find("Button1").GetComponent<Button>().enabled = false;
            GameObject.Find("Button2").GetComponent<Button>().enabled = false;
            GameObject.Find("Menu").GetComponent<SpriteRenderer>().sortingLayerName = "Cielo";
            GameObject.Find("CanvasMenu").GetComponent<Canvas>().sortingLayerName = "Cielo";
            GameObject.Find("Menu").GetComponent<SpriteRenderer>().sortingOrder = -2;
            GameObject.Find("CanvasMenu").GetComponent<Canvas>().sortingOrder = -2;
            showMenu = false;
        }
    }
    
}
