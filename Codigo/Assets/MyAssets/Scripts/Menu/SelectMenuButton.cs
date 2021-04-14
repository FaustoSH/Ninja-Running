using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMenuButton : MonoBehaviour
{
    public void pressed()
    {
        SceneManager.LoadScene("Select");
    }
}
