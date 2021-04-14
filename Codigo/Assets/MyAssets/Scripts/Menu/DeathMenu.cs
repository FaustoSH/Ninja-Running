using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour
{
    [SerializeField] private Transform AdsManager=null;
    public void retry()
    {
        PlayerPrefs.SetInt("Ads", PlayerPrefs.GetInt("Ads") + 1);
        if ((PlayerPrefs.GetInt("Ads") % 4) == 0)
        {
            AdsManager.GetComponent<AdsManager>().DisplayInterstitialAD(0);
        }
        else
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
                Time.timeScale = 1;
                SceneManager.LoadScene("Playing");
            }
        }
        
    }

    public void continuePlaying()
    {
        NinjaController.ninja.transform.position = NinjaController.ninja.secureLocation;
        NinjaController.ninja.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        NinjaController.ninja.stopped = false;
        AdsManager.GetComponent<AdsManager>().DisplayVideoAD(1);
    }

}
