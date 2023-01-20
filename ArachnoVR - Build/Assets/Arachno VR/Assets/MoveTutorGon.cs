using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTutorGon : MonoBehaviour
{
    public GameObject Move;
    public GameObject UITutor;
    public GameObject Barrier;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Move.SetActive(false);
            UITutor.SetActive(true);
            Barrier.SetActive(true);
        }
    }
}
