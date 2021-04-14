using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scrippter : MonoBehaviour
{
    [SerializeField] private Transform level_Part_Start = null;
    [SerializeField] private List<Transform> listParts = null;
    [SerializeField] private List<Transform> listParts2 = null;
    [SerializeField] private List<Transform> listParts3 = null;
    [SerializeField] private List<Transform> listParts4 = null;
    [SerializeField] private List<Transform> listParts5 = null;
    [SerializeField] private Transform newLevel = null;
    [SerializeField] private NinjaController ninja=null;

    private Transform lastPart;
    private Vector3 lastPosition;
    private const float distancia = 7f;
    private bool puertaFabrica = true, puertaHielo = true, puertaVolcan=true, puertaJungla=true;
    private void Start()
    {
        lastPosition = level_Part_Start.Find("Fin").position;
        int startSpawnParts = 7;
        lastPart = level_Part_Start;
        for (int i = 0; i < startSpawnParts; i++)
            SpawnLevelPart();

    }
    void Update()
    {
        if(ninja!=null)
        {
            if ((lastPosition.x - ninja.transform.position.x) < distancia)
            {
                SpawnLevelPart();
            }
            if(ninja.dead)
            {
                Time.timeScale = 0;
                if (JumpButton.boton != null)
                    JumpButton.boton.activado = false;
                GameObject.Find("Settings").GetComponent<Button>().enabled = false;
                GameObject.Find("Continue").GetComponent<Button>().enabled = true;
                GameObject.Find("Retry").GetComponent<Button>().enabled = true;
                GameObject.Find("BackToMenu").GetComponent<Button>().enabled = true;
                GameObject.Find("MenuMuerte").GetComponent<SpriteRenderer>().sortingLayerName = "Menu";
                GameObject.Find("CanvasMenuMuerte").GetComponent<Canvas>().sortingLayerName = "Menu";
                GameObject.Find("video").GetComponent<SpriteRenderer>().sortingLayerName = "Menu";
                GameObject.Find("video").GetComponent<SpriteRenderer>().sortingOrder = 7;
                GameObject.Find("MenuMuerte").GetComponent<SpriteRenderer>().sortingOrder = 6;
                GameObject.Find("CanvasMenuMuerte").GetComponent<Canvas>().sortingOrder = 7;
                ninja.dead = false;
            }
        }
            
    }
    private void SpawnLevelPart()
    {
        Transform chosenPart = null;
        switch(PlayerPrefs.GetInt("Select"))
        {
            case -1:
                do
                {
                    switch (Random.Range(0, 5))
                    {
                        case 0:
                            chosenPart = listParts[Random.Range(0, listParts.Count)];
                            break;
                        case 1:
                            if (PlayerPrefs.GetInt("Hielo") > 0)
                                chosenPart = listParts2[Random.Range(0, listParts2.Count)];
                            break;
                        case 2:
                            if (PlayerPrefs.GetInt("Fabrica") > 0)
                                chosenPart = listParts3[Random.Range(0, listParts3.Count)];
                            break;
                        case 3:
                            if (PlayerPrefs.GetInt("Volcan") > 0)
                                chosenPart = listParts4[Random.Range(0, listParts4.Count)];
                            break;
                        case 4:
                            if (PlayerPrefs.GetInt("Jungla") > 0)
                                chosenPart = listParts5[Random.Range(0, listParts5.Count)];
                            break;
                        default:
                            chosenPart = listParts[Random.Range(0, listParts.Count)];
                            break;
                    }
                } while (chosenPart == null);
                break;
            case 0:
                if (ninja.mapPoints< 50) //Máximo de puntos hasta donde va a estar apareciendo 
                {
                    chosenPart = listParts[Random.Range(0, listParts.Count)];
                    

                }
                else
                {
                    //Cuando querramos ir metiendo nuemos mapas en el case 0 habrá que ir haciendo ifs anidados 
                    if(ninja.mapPoints<100) //Máximo de puntos hasta donde va a estar apareciendo 
                    {
                        if (PlayerPrefs.GetInt("Hielo") == 0 && puertaHielo)
                        {
                            SpawnLevelPart(newLevel, lastPosition);
                            puertaHielo = false;
                            Debug.Log("Estás llegando al hielo");
                        }
                        chosenPart = listParts2[Random.Range(0, listParts2.Count)];
                    }
                    else
                    {
                        if(ninja.mapPoints<150)
                        {
                            if (PlayerPrefs.GetInt("Fabrica") == 0 && puertaFabrica)
                            {
                                SpawnLevelPart(newLevel, lastPosition);
                                puertaFabrica = false;
                                Debug.Log("Estás llegando a la fábrica");
                            }
                            chosenPart = listParts3[Random.Range(0, listParts3.Count)];
                        }else
                        {
                            if (ninja.mapPoints < 200)
                            {
                                if (PlayerPrefs.GetInt("Volcan") == 0 && puertaVolcan)
                                {
                                    SpawnLevelPart(newLevel, lastPosition);
                                    puertaVolcan = false;
                                    Debug.Log("Estás llegando al volcán");
                                }
                                chosenPart = listParts4[Random.Range(0, listParts4.Count)];
                            }else
                            {
                                //if(ninja.mapPoints<250)
                                {
                                    if (PlayerPrefs.GetInt("Jungla") == 0 && puertaJungla)
                                    {
                                        SpawnLevelPart(newLevel, lastPosition);
                                        puertaJungla = false;
                                        Debug.Log("Estás llegando a la jungla");
                                    }
                                    chosenPart = listParts5[Random.Range(0, listParts5.Count)];
                                }
                            }
                        }
                        
                    }
                    
                }
                break;
            case 1:
                chosenPart = listParts2[Random.Range(0, listParts2.Count)];
                break;
            case 2:
                chosenPart = listParts3[Random.Range(0, listParts3.Count)];
                break;
            case 3:
                chosenPart = listParts4[Random.Range(0, listParts4.Count)];
                break;
            case 4:
                chosenPart= listParts5[Random.Range(0, listParts5.Count)];
                break;

        }
        if (chosenPart != lastPart&&chosenPart!=null)
        {
            Transform lastLevelPartTransform = SpawnLevelPart(chosenPart, lastPosition);
            lastPosition = lastLevelPartTransform.Find("Fin").position;
            lastPart = chosenPart;
        }


    }
    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        spawnPosition = new Vector3(spawnPosition.x, spawnPosition.y, 0);
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}
