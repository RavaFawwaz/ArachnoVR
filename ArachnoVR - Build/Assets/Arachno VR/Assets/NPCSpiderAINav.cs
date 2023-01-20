using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCSpiderAINav : MonoBehaviour
{
    public GameObject Destination;
    public int rotate;
    public int time;
    NavMeshAgent theAgent;


    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
    }

    
    public void SpiderNPCWalk()
    {

        theAgent.SetDestination(Destination.transform.position);

        StartCoroutine(SpiderWalk());

    }

    private IEnumerator SpiderWalk()
    {
        theAgent.GetComponent<Animator>().Play("WalkFWD");

        yield return new WaitForSeconds(time);

        theAgent.GetComponent<Animator>().Play("IdleNormal");
        theAgent.transform.rotation = Quaternion.Euler(new Vector3(0, rotate, 0));
    }
    
}
