using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void backToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void backToMenuFromSelect()
    {
        switch(PlayerPrefs.GetInt("Select"))
        {
            case 1:
                if(PlayerPrefs.GetInt("Hielo")==1)
                {
                    SceneManager.LoadScene("MainMenu");
                }
                break;
            case 2:
                if(PlayerPrefs.GetInt("Fabrica")==1)
                {
                    SceneManager.LoadScene("MainMenu");
                }
                break;
            case 3:
                if (PlayerPrefs.GetInt("Volcan") == 1)
                {
                    SceneManager.LoadScene("MainMenu");
                }
                break;
            case 4:
                if (PlayerPrefs.GetInt("Jungla") == 1)
                {
                    SceneManager.LoadScene("MainMenu");
                }
                break;
            default:
                SceneManager.LoadScene("MainMenu");
                break;
        }
    }

    public void backToMenuFromDeath()
    {
        if (NinjaController.ninja != null)
        {
            if (PlayerPrefs.HasKey("HighScore"))
            {
                if (PlayerPrefs.GetInt("HighScore") < NinjaController.ninja.points)
                {
                    PlayerPrefs.SetInt("HighScore", NinjaController.ninja.points);
                }
            }
            else
            {
                PlayerPrefs.SetInt("HighScore", NinjaController.ninja.points);
            }
            SceneManager.LoadScene("MainMenu");
        }
    }
}
