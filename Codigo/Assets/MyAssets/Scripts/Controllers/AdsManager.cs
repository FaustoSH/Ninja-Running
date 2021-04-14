using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AdsManager : MonoBehaviour, IUnityAdsListener
{
    string GooglePlayId = ""; //Censurado por privacidad
    string myPlacementId = "rewardedVideo";
    bool testMode = false;
    private int button = 0;
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(GooglePlayId, testMode);
    }

    public void DisplayInterstitialAD(int buttonPressed)
    {
        button = buttonPressed;
        Advertisement.Show();
    }

    public void DisplayVideoAD(int buttonPressed)
    {
        button = buttonPressed;
        Advertisement.Show(myPlacementId);
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            if (SceneManager.GetActiveScene().name.Equals("Playing"))
            {
                switch(button)
                {
                    case 0:
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
                        break;

                    case 1:
                        if (NinjaController.ninja != null)
                        {
                            
                            GameObject.Find("Settings").GetComponent<Button>().enabled = true;
                            GameObject.Find("Continue").GetComponent<Button>().enabled = false;
                            GameObject.Find("Retry").GetComponent<Button>().enabled = false;
                            GameObject.Find("BackToMenu").GetComponent<Button>().enabled = false;
                            GameObject.Find("video").GetComponent<SpriteRenderer>().sortingLayerName = "Cielo";
                            GameObject.Find("MenuMuerte").GetComponent<SpriteRenderer>().sortingLayerName = "Cielo";
                            GameObject.Find("CanvasMenuMuerte").GetComponent<Canvas>().sortingLayerName = "Cielo";
                            GameObject.Find("video").GetComponent<SpriteRenderer>().sortingOrder = -2;
                            GameObject.Find("MenuMuerte").GetComponent<SpriteRenderer>().sortingOrder = -2;
                            GameObject.Find("CanvasMenuMuerte").GetComponent<Canvas>().sortingOrder = -2;
                            GameObject.Find("ContinueButton").GetComponent<Button>().enabled = true;
                            GameObject.Find("CanvasPlayButton").GetComponent<Canvas>().sortingOrder = 7;
                            GameObject.Find("CanvasPlayButton").GetComponent<Canvas>().sortingLayerName = "Menu";
                        }
                        break;
                    default:
                        //Se supone que aquí no va a llegar nunca
                        break;
                }
                
            }
            else if (SceneManager.GetActiveScene().name.Equals("MainMenu"))
            {
                SceneManager.LoadScene("Playing");
            }
        }
        else if (showResult == ShowResult.Skipped)
        {
            if(SceneManager.GetActiveScene().name.Equals("Playing"))
            {
                switch(button)
                {
                    case 0:
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
                        break;
                    case 1:
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
                        break;
                    default:
                        //Aquí se supone que no llega
                        break;
                }
                
            }else if(SceneManager.GetActiveScene().name.Equals("MainMenu"))
            {
                SceneManager.LoadScene("Playing");
            }
            
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        // If the ready Placement is rewarded, show the ad:
        if (placementId == myPlacementId)
        {
            //Advertisement.Show(myPlacementId);
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }

    // When the object that subscribes to ad events is destroyed, remove the listener:
    public void OnDestroy()
    {
        Advertisement.RemoveListener(this);
    }
}
