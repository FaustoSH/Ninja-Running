using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public void reset()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        PlayerPrefs.SetInt("Fabrica", 0);
        PlayerPrefs.SetInt("Hielo", 0);
        PlayerPrefs.SetInt("Volcan", 0);
        PlayerPrefs.SetInt("Jungla", 0);
        PlayerPrefs.SetInt("Select", 0);
    }
}
