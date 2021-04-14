using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
{
    public void continuePlaying()
    {
        if(NinjaController.ninja!=null)
        {
            if (JumpButton.boton != null)
                JumpButton.boton.activado = true;
            GameObject.Find("ContinueButton").GetComponent<Button>().enabled = false;
            GameObject.Find("CanvasPlayButton").GetComponent<Canvas>().sortingOrder = -7;
            GameObject.Find("CanvasPlayButton").GetComponent<Canvas>().sortingLayerName = "Cielo";
            Time.timeScale = 1;
        }
    }
}
