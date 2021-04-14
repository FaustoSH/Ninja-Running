using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class NewLevelController : MonoBehaviour
{
    private const float distancia = 7f;

    // Update is called once per frame
    /*void Update()
    {
        if (NinjaController.ninja != null)
            if ((NinjaController.ninja.transform.position.x - gameObject.transform.position.x) > distancia)
            {
                Destroy(gameObject);
            } 
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (PlayerPrefs.GetInt("Hielo") == 0)
        {
            PlayerPrefs.SetInt("Hielo", 1);
            Debug.Log("Se ha desbloqueado el hielo");
            Destroy(gameObject);
        }
        else
        {
            //Aquí se van a ir poniendo anidados los demás mapas
            if (PlayerPrefs.GetInt("Fabrica") == 0)
            {
                PlayerPrefs.SetInt("Fabrica", 1);
                Debug.Log("Se ha desbloqueado la fábrica");
                Destroy(gameObject);
            }
            else 
            {
                if (PlayerPrefs.GetInt("Volcan") == 0)
                {
                    PlayerPrefs.SetInt("Volcan", 1);
                    Debug.Log("Se ha desbloqueado el Volcan");
                    Destroy(gameObject);
                }else
                {
                    if(PlayerPrefs.GetInt("Jungla")==0)
                    {
                        PlayerPrefs.SetInt("Jungla", 1);
                        Debug.Log("Se ha desbloqueado la Jungla");
                        Destroy(gameObject);
                    }
                }
            }
        }
    }
}
