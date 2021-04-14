using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text score;
    private void Start()
    {
        score = GameObject.Find("Score").GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        if(NinjaController.ninja!=null)
            score.text = NinjaController.ninja.points.ToString();
    }
}
