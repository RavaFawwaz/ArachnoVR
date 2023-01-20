using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManualMove : MonoBehaviour
{
    public Transform target;
    public int rotate;

    public void MoveManual()
    {
        transform.position = target.position;
        transform.rotation = Quaternion.Euler(new Vector3(0, rotate, 0));
    }
}
