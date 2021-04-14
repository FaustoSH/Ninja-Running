using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    private Text hs;
    // Start is called before the first frame update
    void Start()
    {
        hs = GameObject.Find("HighScore").GetComponent<Text>();
        if (PlayerPrefs.HasKey("HighScore"))
        {
            hs.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            hs.text = "High Score: 0";
        }
            
    }
    private void Update()
    {
        hs.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
    }
}
