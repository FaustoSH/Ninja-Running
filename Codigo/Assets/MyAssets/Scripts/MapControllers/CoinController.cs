using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private int maxMapPoints = 250;
    private void Start()
    {
        bool newBool = Random.Range(0, 2) > 0;
        if(newBool)
        {
            Destroy(transform.parent.gameObject);
        }
    }
    private void Update()
    {
        gameObject.transform.rotation = Quaternion.Euler(0, gameObject.transform.rotation.eulerAngles.y+8, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(PlayerPrefs.GetInt("Sounds")>0)
            GameObject.Find("Audio Source2").GetComponent<AudioSource>().Play();

        if ((NinjaController.ninja.mapPoints + 1 )==maxMapPoints)
            NinjaController.ninja.mapPoints = 0;
        else
            NinjaController.ninja.mapPoints++;
        NinjaController.ninja.points++;
        Destroy(transform.parent.gameObject);
    }
}
