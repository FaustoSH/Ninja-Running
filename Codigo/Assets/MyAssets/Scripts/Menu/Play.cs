using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    [SerializeField] private Transform AdsManager=null;
    public void letsPlay()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("Ads", PlayerPrefs.GetInt("Ads") + 1);
        if((PlayerPrefs.GetInt("Ads")%4)==0)
        {
            AdsManager.GetComponent<AdsManager>().DisplayInterstitialAD(-1); 
        }else
        {
            switch(PlayerPrefs.GetInt("Select"))
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
            SceneManager.LoadScene("Playing");
        }
        
        
    }
}
