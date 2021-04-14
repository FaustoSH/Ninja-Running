using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Sounds"))
        {
            bool newBool = PlayerPrefs.GetInt("Sounds") > 0;
            if (newBool)
            {
                gameObject.GetComponent<AudioSource>().Play();
            }
            else
                gameObject.GetComponent<AudioSource>().Stop();
        }
        else
        {
            gameObject.GetComponent<AudioSource>().Play();
            PlayerPrefs.SetInt("Sounds", 1);
        }
    }

    private void UpdateUpdate()
    {
        if (PlayerPrefs.HasKey("Sounds"))
        {
            bool newBool = PlayerPrefs.GetInt("Sounds") > 0;
            if (newBool)
            {
                gameObject.GetComponent<AudioSource>().Play();
            }
            else
                gameObject.GetComponent<AudioSource>().Stop();
        }
            
    }
}
