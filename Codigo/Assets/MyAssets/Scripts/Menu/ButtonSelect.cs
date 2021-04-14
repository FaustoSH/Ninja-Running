using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSelect : MonoBehaviour
{
    private int MaxNumLevels=4;
    public void rightButton()
    {

        if((PlayerPrefs.GetInt("Select")+1)>MaxNumLevels)
            PlayerPrefs.SetInt("Select", -1);
        else
            PlayerPrefs.SetInt("Select", PlayerPrefs.GetInt("Select") + 1);
    }

    public void leftButton()
    { 
        if ((PlayerPrefs.GetInt("Select") -1)<-1)
            PlayerPrefs.SetInt("Select", MaxNumLevels);
        else
            PlayerPrefs.SetInt("Select", PlayerPrefs.GetInt("Select") - 1);
    }
}
