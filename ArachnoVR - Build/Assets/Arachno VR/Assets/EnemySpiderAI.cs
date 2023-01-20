using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpiderAI : MonoBehaviour
{
    public GameObject Destination;
    NavMeshAgent theAgent;
    public GameObject SpiderEnemy;
    public GameManager gameManager;
    public GameObject Smoke;


    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {

        theAgent.SetDestination(Destination.transform.position);


    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {

            StartCoroutine(SpiderBite());

        }
        
    }

    public void SpiderDed()
    {
        StartCoroutine(SpiderAniDed());

    }

    private IEnumerator SpiderBite()
    {
        theAgent.GetComponent<Animator>().Play("Bite Attack");

        yield return new WaitForSeconds(1);

        SpiderEnemy.SetActive(false);
        gameManager.Attacked();
        Destroy(SpiderEnemy);
    }



    private IEnumerator SpiderAniDed()
    {
        
        Smoke.SetActive(true);

        yield return new WaitForSeconds(1);

        SpiderEnemy.SetActive(false);
        gameManager.AddPoint();
        Destroy(SpiderEnemy);
    }
}
