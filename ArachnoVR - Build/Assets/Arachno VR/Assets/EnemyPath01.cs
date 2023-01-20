using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath01 : MonoBehaviour
{
    public int Point;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {

            if (Point == 5)
            {
                this.gameObject.transform.position = new Vector3(83, 1, 18);
                Point = 6;
            }
            if (Point == 4)
            {
                this.gameObject.transform.position = new Vector3(79, 1, 17);
                Point = 5;
            }
            if (Point == 3)
            {
                this.gameObject.transform.position = new Vector3(80, 1, 27);
                Point = 4;
            }
            if (Point == 2)
            {
                this.gameObject.transform.position = new Vector3(77, 1, 24);
                Point = 3;
            }
            if (Point == 1)
            {
                this.gameObject.transform.position = new Vector3(75, 1, 17);
                Point = 2;
            }
            if (Point == 0)
            {
                this.gameObject.transform.position = new Vector3(72, 1, 22);
                Point = 1;
            }
        }
    }
}
