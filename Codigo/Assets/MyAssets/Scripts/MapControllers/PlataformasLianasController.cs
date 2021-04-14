using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Scripting;

public class PlataformasLianasController : MonoBehaviour
{
    [SerializeField] public List<Transform> lianas = null;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<lianas.Count-1; i++)
        {
            lianas[i].GetComponent<Animator>().Play("Base Layer.liana", Random.Range(0, 101) / 100, Random.Range(0, 101) / 100);
        }
    }

}
