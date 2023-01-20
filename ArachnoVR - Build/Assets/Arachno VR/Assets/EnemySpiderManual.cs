using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpiderManual : MonoBehaviour
{
    public Transform Destination;
    public GameObject SpiderEnemy;
    public GameManager gameManager;
    public float speed;


    void Start()
    {

    }


    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, Destination.position, speed);


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {

            StartCoroutine(SpiderBite());

        }
    }

    private IEnumerator SpiderBite()
    {
        GetComponent<Animator>().Play("Bite Attack");

        yield return new WaitForSeconds(1);

        SpiderEnemy.SetActive(false);
        gameManager.Attacked();
    }

    public void SpiderDed()
    {
        StartCoroutine(SpiderAniDed());
    }

    private IEnumerator SpiderAniDed()
    {
        GetComponent<Animator>().Play("Die");

        yield return new WaitForSeconds(1);

        SpiderEnemy.SetActive(false);
        gameManager.AddPoint();
    }
}
