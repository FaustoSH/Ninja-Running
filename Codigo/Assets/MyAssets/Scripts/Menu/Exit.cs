using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void exit()
    {
        PlayerPrefs.SetInt("Select", 0);
        Application.Quit();
    }
}
