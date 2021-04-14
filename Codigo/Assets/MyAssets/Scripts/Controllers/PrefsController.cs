using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefsController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Fabrica"))
            PlayerPrefs.SetInt("Fabrica", 0);
        if (!PlayerPrefs.HasKey("Hielo"))
            PlayerPrefs.SetInt("Hielo", 0);
        if (!PlayerPrefs.HasKey("Volcan"))
            PlayerPrefs.SetInt("Volcan", 0);
        if (!PlayerPrefs.HasKey("Jungla"))
            PlayerPrefs.SetInt("Jungla", 0);
        if (!PlayerPrefs.HasKey("Ads"))
            PlayerPrefs.SetInt("Ads", 0);
        switch (PlayerPrefs.GetInt("Select"))
        {
            case -1:
                break;
            case 0:
                break;
            case 1:
                if (PlayerPrefs.GetInt("Hielo") == 0)
                    PlayerPrefs.SetInt("Select", 0);
                break;
            case 2:
                if (PlayerPrefs.GetInt("Fabrica") == 0)
                    PlayerPrefs.SetInt("Select", 0);
                break;
            case 3:
                if (PlayerPrefs.GetInt("Volcan") == 0)
                    PlayerPrefs.SetInt("Select", 0);
                break;
            case 4:
                if (PlayerPrefs.GetInt("Jungla") == 0)
                    PlayerPrefs.SetInt("Select", 0);
                break;

        }
        if (!PlayerPrefs.HasKey("MainMenuVisits"))
        {
            PlayerPrefs.SetInt("MainMenuVisits", 0);
        }else
        {
            if(PlayerPrefs.GetInt("MainMenuVisits")<3)
            {
                PlayerPrefs.SetInt("MainMenuVisits", PlayerPrefs.GetInt("MainMenuVisits")+1);
            }else if(PlayerPrefs.GetInt("MainMenuVisits") == 3)
            {
                GameObject.Find("Settings").GetComponent<Button>().enabled = false;
                GameObject.Find("Play").GetComponent<Button>().enabled = false;
                GameObject.Find("Select").GetComponent<Button>().enabled = false;
                GameObject.Find("YES").GetComponent<Button>().enabled = true;
                GameObject.Find("NO").GetComponent<Button>().enabled = true;
                GameObject.Find("CanvasRate").GetComponent<Canvas>().sortingLayerName = "Menu";
                GameObject.Find("CanvasRate").GetComponent<Canvas>().sortingOrder = 2;
                GameObject.Find("Menu2").GetComponent<SpriteRenderer>().sortingLayerName = "Menu";
                GameObject.Find("Menu2").GetComponent<SpriteRenderer>().sortingOrder = 2;
            }
        }
    }
}
