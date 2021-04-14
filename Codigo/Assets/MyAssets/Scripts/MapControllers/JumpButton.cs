using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static JumpButton boton;
    private bool pressed = false;
    private int numPress = 0;
    public bool activado = true;
    private void Start()
    {
        boton = this;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
        if(NinjaController.ninja!=null)
            if (NinjaController.ninja.canJump && pressed && numPress == 0 && activado)
            {
                NinjaController.ninja.jump();
            }
        numPress = 1;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
        numPress = 0;
    }

}
