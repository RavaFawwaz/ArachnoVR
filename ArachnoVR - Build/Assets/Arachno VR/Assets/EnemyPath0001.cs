using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath0001 : MonoBehaviour
{
    public int Point;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {

            if (Point == 3)
            {
                this.gameObject.transform.position = new Vector3(57, 51, 68);
                Point = 4;
            }
            if (Point == 2)
            {
                this.gameObject.transform.position = new Vector3(53, 51, 71);
                Point = 3;
            }
            if (Point == 1)
            {
                this.gameObject.transform.position = new Vector3(53, 51, 74);
                Point = 2;
            }
            if (Point == 0)
            {
                this.gameObject.transform.position = new Vector3(56, 51, 82);
                Point = 1;
            }
        }
    }
}
