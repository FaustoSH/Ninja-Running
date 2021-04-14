using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yesNo : MonoBehaviour
{
    public void no()
    {
        GameObject.Find("Settings").GetComponent<Button>().enabled = true;
        GameObject.Find("Play").GetComponent<Button>().enabled = true;
        GameObject.Find("Select").GetComponent<Button>().enabled = true;
        GameObject.Find("YES").GetComponent<Button>().enabled = false;
        GameObject.Find("NO").GetComponent<Button>().enabled = false;
        GameObject.Find("CanvasRate").GetComponent<Canvas>().sortingLayerName = "Cielo";
        GameObject.Find("CanvasRate").GetComponent<Canvas>().sortingOrder = -2;
        GameObject.Find("Menu2").GetComponent<SpriteRenderer>().sortingLayerName = "Cielo";
        GameObject.Find("Menu2").GetComponent<SpriteRenderer>().sortingOrder = -2;
        PlayerPrefs.SetInt("MainMenuVisits", -7);
    }

    public void yes()
    {
        GameObject.Find("Settings").GetComponent<Button>().enabled = true;
        GameObject.Find("Play").GetComponent<Button>().enabled = true;
        GameObject.Find("Select").GetComponent<Button>().enabled = true;
        GameObject.Find("YES").GetComponent<Button>().enabled = false;
        GameObject.Find("NO").GetComponent<Button>().enabled = false;
        GameObject.Find("CanvasRate").GetComponent<Canvas>().sortingLayerName = "Cielo";
        GameObject.Find("CanvasRate").GetComponent<Canvas>().sortingOrder = -2;
        GameObject.Find("Menu2").GetComponent<SpriteRenderer>().sortingLayerName = "Cielo";
        GameObject.Find("Menu2").GetComponent<SpriteRenderer>().sortingOrder = -2;
        PlayerPrefs.SetInt("MainMenuVisits", 6);
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.OtsuafGames.NinjaRunning");
    }
}
