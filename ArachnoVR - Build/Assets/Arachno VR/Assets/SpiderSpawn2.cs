using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderSpawn2 : MonoBehaviour
{
    public GameObject[] SpiderEnemy;



    public void SpiderSpawn()
    {

        StartCoroutine(SpiderArrive());


    }

    private IEnumerator SpiderArrive()
    {
        
        for (int i = 0; i < 15; i++)
        {
            SpiderEnemy[i].SetActive(true);
            yield return new WaitForSeconds(11);
        }

    }
}
