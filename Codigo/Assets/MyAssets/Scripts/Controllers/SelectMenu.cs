using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectMenu : MonoBehaviour
{
    private void Start()
    {
        if(PlayerPrefs.HasKey("Select"))
        {
            switch (PlayerPrefs.GetInt("Select"))
            {
                case -1:
                    if (SceneManager.GetActiveScene().name.Equals("Select"))
                    {
                        GameObject.Find("SelectionText").GetComponent<Text>().text = string.Format("Random Mode:\nRun through your\nunlocked maps randomly");
                        GameObject.Find("SelectionText").GetComponent<Text>().color = new Color(195, 195, 195);
                    }
                    GameObject.Find("MenuBackgroundR").GetComponent<SpriteRenderer>().sortingOrder = 1;
                    GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground1").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground1B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground2").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground2B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground3").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground3B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground4").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground4B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    break;
                case 0:
                    if (SceneManager.GetActiveScene().name.Equals("Select"))
                    {
                        GameObject.Find("SelectionText").GetComponent<Text>().text = string.Format("Normal Mode:\nRun and unlock\nthe different maps");
                        GameObject.Find("SelectionText").GetComponent<Text>().color = new Color(195, 195, 195);
                    }
                    
                    GameObject.Find("MenuBackgroundR").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = 1;
                    GameObject.Find("MenuBackground1").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground1B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground2").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground2B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground3").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground3B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground4").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground4B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    break;
                case 1:
                    if (SceneManager.GetActiveScene().name.Equals("Select"))
                    {
                        GameObject.Find("SelectionText").GetComponent<Text>().text = string.Format("Ice map mode:\nrun and collect coins\nin the ice map");
                        GameObject.Find("SelectionText").GetComponent<Text>().color = new Color(80, 80, 80);
                    }
                    
                    GameObject.Find("MenuBackgroundR").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    if (PlayerPrefs.GetInt("Hielo") == 1)
                        GameObject.Find("MenuBackground1").GetComponent<SpriteRenderer>().sortingOrder = 1;
                    else if (SceneManager.GetActiveScene().name.Equals("Select"))
                        GameObject.Find("MenuBackground1B").GetComponent<SpriteRenderer>().sortingOrder = 1;
                    else
                        GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = 1;
                    GameObject.Find("MenuBackground2").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground2B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground3").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground3B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground4").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground4B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    break;
                case 2:
                    if (SceneManager.GetActiveScene().name.Equals("Select"))
                    {
                        GameObject.Find("SelectionText").GetComponent<Text>().text = string.Format("Factory map mode:\nrun and collect coins\nin the factory map");
                        GameObject.Find("SelectionText").GetComponent<Text>().color = new Color(195, 195, 195);
                    }
                    
                    GameObject.Find("MenuBackgroundR").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground1").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground1B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    if (PlayerPrefs.GetInt("Fabrica") == 1)
                        GameObject.Find("MenuBackground2").GetComponent<SpriteRenderer>().sortingOrder = 1;
                    else if (SceneManager.GetActiveScene().name.Equals("Select"))
                        GameObject.Find("MenuBackground2B").GetComponent<SpriteRenderer>().sortingOrder = 1;
                    else
                        GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = 1;
                    GameObject.Find("MenuBackground3").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground3B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground4").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground4B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    break;
                case 3:
                    if (SceneManager.GetActiveScene().name.Equals("Select"))
                    {
                        GameObject.Find("SelectionText").GetComponent<Text>().text = string.Format("Vulcano map mode:\nrun and collect coins\nin the vulcano map");
                        GameObject.Find("SelectionText").GetComponent<Text>().color = new Color(255, 255, 255);
                    }
                    
                    GameObject.Find("MenuBackgroundR").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground1").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground1B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground2").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground2B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    if (PlayerPrefs.GetInt("Volcan") == 1)
                        GameObject.Find("MenuBackground3").GetComponent<SpriteRenderer>().sortingOrder = 1;
                    else if (SceneManager.GetActiveScene().name.Equals("Select"))
                        GameObject.Find("MenuBackground3B").GetComponent<SpriteRenderer>().sortingOrder = 1;
                    else
                        GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = 1;
                    GameObject.Find("MenuBackground4").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground4B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    break;
                case 4:
                    if (SceneManager.GetActiveScene().name.Equals("Select"))
                    {
                        GameObject.Find("SelectionText").GetComponent<Text>().text = string.Format("Jungle map mode:\nrun and collect coins\nin the jungle map");
                        GameObject.Find("SelectionText").GetComponent<Text>().color = new Color(195, 195, 195);
                    }

                    GameObject.Find("MenuBackgroundR").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground1").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground1B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground2").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground2B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground3").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground3B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    if (PlayerPrefs.GetInt("Jungla") == 1)
                        GameObject.Find("MenuBackground4").GetComponent<SpriteRenderer>().sortingOrder = 1;
                    else if (SceneManager.GetActiveScene().name.Equals("Select"))
                        GameObject.Find("MenuBackground4B").GetComponent<SpriteRenderer>().sortingOrder = 1;
                    else
                        GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = 1;
                    break;
                default:
                    if (SceneManager.GetActiveScene().name.Equals("Select"))
                    {
                        GameObject.Find("SelectionText").GetComponent<Text>().text = string.Format("Normal Mode:\nRun and unlock\nthe different maps");
                        GameObject.Find("SelectionText").GetComponent<Text>().color = new Color(195, 195, 195);
                    }
                    
                    GameObject.Find("MenuBackgroundR").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = 1;
                    GameObject.Find("MenuBackground1").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground1B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground2").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground2B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground3").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground3B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground4").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    GameObject.Find("MenuBackground4B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                    break;
            }
        }
        else
        {
            if (SceneManager.GetActiveScene().name.Equals("Select"))
            {
                GameObject.Find("SelectionText").GetComponent<Text>().text = string.Format("Normal Mode:\nRun and unlock\nthe different maps");
                GameObject.Find("SelectionText").GetComponent<Text>().color = new Color(195, 195, 195);
            }
            
            PlayerPrefs.SetInt("Select", 0);
            GameObject.Find("MenuBackgroundR").GetComponent<SpriteRenderer>().sortingOrder = -1;
            GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = 1;
            GameObject.Find("MenuBackground1").GetComponent<SpriteRenderer>().sortingOrder = -1;
            GameObject.Find("MenuBackground1B").GetComponent<SpriteRenderer>().sortingOrder = -1;
            GameObject.Find("MenuBackground2").GetComponent<SpriteRenderer>().sortingOrder = -1;
            GameObject.Find("MenuBackground2B").GetComponent<SpriteRenderer>().sortingOrder = -1;
            GameObject.Find("MenuBackground3").GetComponent<SpriteRenderer>().sortingOrder = -1;
            GameObject.Find("MenuBackground3B").GetComponent<SpriteRenderer>().sortingOrder = -1;
            GameObject.Find("MenuBackground4").GetComponent<SpriteRenderer>().sortingOrder = -1;
            GameObject.Find("MenuBackground4B").GetComponent<SpriteRenderer>().sortingOrder = -1;
        }
    }

    private void Update()
    {
        switch (PlayerPrefs.GetInt("Select"))
        {
            case -1:
                if (SceneManager.GetActiveScene().name.Equals("Select"))
                {
                    GameObject.Find("SelectionText").GetComponent<Text>().text = string.Format("Random Mode:\nRun through your\nunlocked maps randomly");
                    GameObject.Find("SelectionText").GetComponent<Text>().color = new Color(195, 195, 195);
                }
                GameObject.Find("MenuBackgroundR").GetComponent<SpriteRenderer>().sortingOrder = 1;
                GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground1").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground1B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground2").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground2B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground3").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground3B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground4").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground4B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                break;
            case 0:
                if (SceneManager.GetActiveScene().name.Equals("Select"))
                {
                    GameObject.Find("SelectionText").GetComponent<Text>().text = string.Format("Normal Mode:\nRun and unlock\nthe different maps");
                    GameObject.Find("SelectionText").GetComponent<Text>().color = new Color(195, 195, 195);
                }

                GameObject.Find("MenuBackgroundR").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = 1;
                GameObject.Find("MenuBackground1").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground1B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground2").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground2B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground3").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground3B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground4").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground4B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                break;
            case 1:
                if (SceneManager.GetActiveScene().name.Equals("Select"))
                {
                    GameObject.Find("SelectionText").GetComponent<Text>().text = string.Format("Ice map mode:\nrun and collect coins\nin the ice map");
                    GameObject.Find("SelectionText").GetComponent<Text>().color = new Color(80, 80, 80);
                }

                GameObject.Find("MenuBackgroundR").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = -1;
                if (PlayerPrefs.GetInt("Hielo") == 1)
                    GameObject.Find("MenuBackground1").GetComponent<SpriteRenderer>().sortingOrder = 1;
                else if (SceneManager.GetActiveScene().name.Equals("Select"))
                    GameObject.Find("MenuBackground1B").GetComponent<SpriteRenderer>().sortingOrder = 1;
                else
                    GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = 1;
                GameObject.Find("MenuBackground2").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground2B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground3").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground3B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground4").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground4B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                break;
            case 2:
                if (SceneManager.GetActiveScene().name.Equals("Select"))
                {
                    GameObject.Find("SelectionText").GetComponent<Text>().text = string.Format("Factory map mode:\nrun and collect coins\nin the factory map");
                    GameObject.Find("SelectionText").GetComponent<Text>().color = new Color(195, 195, 195);
                }

                GameObject.Find("MenuBackgroundR").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground1").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground1B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                if (PlayerPrefs.GetInt("Fabrica") == 1)
                    GameObject.Find("MenuBackground2").GetComponent<SpriteRenderer>().sortingOrder = 1;
                else if (SceneManager.GetActiveScene().name.Equals("Select"))
                    GameObject.Find("MenuBackground2B").GetComponent<SpriteRenderer>().sortingOrder = 1;
                else
                    GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = 1;
                GameObject.Find("MenuBackground3").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground3B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground4").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground4B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                break;
            case 3:
                if (SceneManager.GetActiveScene().name.Equals("Select"))
                {
                    GameObject.Find("SelectionText").GetComponent<Text>().text = string.Format("Vulcano map mode:\nrun and collect coins\nin the vulcano map");
                    GameObject.Find("SelectionText").GetComponent<Text>().color = new Color(255, 255, 255);
                }

                GameObject.Find("MenuBackgroundR").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground1").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground1B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground2").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground2B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                if (PlayerPrefs.GetInt("Volcan") == 1)
                    GameObject.Find("MenuBackground3").GetComponent<SpriteRenderer>().sortingOrder = 1;
                else if (SceneManager.GetActiveScene().name.Equals("Select"))
                    GameObject.Find("MenuBackground3B").GetComponent<SpriteRenderer>().sortingOrder = 1;
                else
                    GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = 1;
                GameObject.Find("MenuBackground4").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground4B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                break;
            case 4:
                if (SceneManager.GetActiveScene().name.Equals("Select"))
                {
                    GameObject.Find("SelectionText").GetComponent<Text>().text = string.Format("Jungle map mode:\nrun and collect coins\nin the jungle map");
                    GameObject.Find("SelectionText").GetComponent<Text>().color = new Color(195, 195, 195);
                }

                GameObject.Find("MenuBackgroundR").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground1").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground1B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground2").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground2B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground3").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground3B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                if (PlayerPrefs.GetInt("Jungla") == 1)
                    GameObject.Find("MenuBackground4").GetComponent<SpriteRenderer>().sortingOrder = 1;
                else if (SceneManager.GetActiveScene().name.Equals("Select"))
                    GameObject.Find("MenuBackground4B").GetComponent<SpriteRenderer>().sortingOrder = 1;
                else
                    GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = 1;
                break;
            default:
                if (SceneManager.GetActiveScene().name.Equals("Select"))
                {
                    GameObject.Find("SelectionText").GetComponent<Text>().text = string.Format("Normal Mode:\nRun and unlock\nthe different maps");
                    GameObject.Find("SelectionText").GetComponent<Text>().color = new Color(195, 195, 195);
                }


                GameObject.Find("MenuBackgroundR").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground0").GetComponent<SpriteRenderer>().sortingOrder = 1;
                GameObject.Find("MenuBackground1").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground1B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground2").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground2B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground3").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground3B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground4").GetComponent<SpriteRenderer>().sortingOrder = -1;
                GameObject.Find("MenuBackground4B").GetComponent<SpriteRenderer>().sortingOrder = -1;
                break;
        }
    }
}
