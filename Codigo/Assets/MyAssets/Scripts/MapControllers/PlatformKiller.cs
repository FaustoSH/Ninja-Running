using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformKiller : MonoBehaviour
{
    private const float distancia = 14f;
    // Update is called once per frame
    void Update()
    {
        if(NinjaController.ninja!=null)
            if ((NinjaController.ninja.transform.position.x - gameObject.transform.position.x) > distancia)
                Destroy(gameObject);
    }
}
