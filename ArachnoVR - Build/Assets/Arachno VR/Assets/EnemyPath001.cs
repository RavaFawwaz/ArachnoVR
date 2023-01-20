using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath001 : MonoBehaviour
{
    public int Point;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {

            if (Point == 10)
            {
                this.gameObject.transform.position = new Vector3(408, 292, 174);
                Point = 11;
            }
            if (Point == 9)
            {
                this.gameObject.transform.position = new Vector3(408, 292, 170);
                Point = 10;
            }
            if (Point == 8)
            {
                this.gameObject.transform.position = new Vector3(412, 292, 173);
                Point = 9;
            }
            if (Point == 7)
            {
                this.gameObject.transform.position = new Vector3(415, 292, 179);
                Point = 8;
            }
            if (Point == 6)
            {
                this.gameObject.transform.position = new Vector3(413, 292, 186);
                Point = 7;
            }
            if (Point == 5)
            {
                this.gameObject.transform.position = new Vector3(408, 293, 190);
                Point = 6;
            }
            if (Point == 4)
            {
                this.gameObject.transform.position = new Vector3(404, 292, 186);
                Point = 5;
            }
            if (Point == 3)
            {
                this.gameObject.transform.position = new Vector3(400, 292, 181);
                Point = 4;
            }if (Point == 2)
            {
                this.gameObject.transform.position = new Vector3(398, 292, 173);
                Point = 3;
            }
            if (Point == 1)
            {
                this.gameObject.transform.position = new Vector3(403, 292, 165);
                Point = 2;
            }
            if (Point == 0)
            {
                this.gameObject.transform.position = new Vector3(413, 292, 168);
                Point = 1;
            }
        }
    }
}
