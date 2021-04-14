using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SoundButton : MonoBehaviour
{
    private bool muted;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Sounds"))
        {
            bool newBool = PlayerPrefs.GetInt("Sounds") > 0;
            if (newBool)
            {
                gameObject.GetComponent<Animator>().SetBool("Sounds", true);
                GameObject.Find("Audio Source").GetComponent<AudioSource>().Play();
                muted = false;
            }
            else
            {
                gameObject.GetComponent<Animator>().SetBool("Sounds", false);
                GameObject.Find("Audio Source").GetComponent<AudioSource>().Stop();
                muted = true;
            }
        }
        else
        {
            
            gameObject.GetComponent<Animator>().SetBool("Sounds", true);
            PlayerPrefs.SetInt("Sounds", 1);
            GameObject.Find("Audio Source").GetComponent<AudioSource>().Play();
            muted = false;
        }
    }
    public void pressed()
    {
        PlayerPrefs.GetInt("Sounds");
        if (muted)
        {
            gameObject.GetComponent<Animator>().SetBool("Sounds", true);
            GameObject.Find("Audio Source").GetComponent<AudioSource>().Play();
            PlayerPrefs.SetInt("Sounds", 1);
            muted = false;
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("Sounds", false);
            GameObject.Find("Audio Source").GetComponent<AudioSource>().Stop();
            PlayerPrefs.SetInt("Sounds", 0);
            muted = true;
        }
    }

}
