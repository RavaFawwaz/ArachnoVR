using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanahUpDown : MonoBehaviour
{
    public float Amp;
    public float x;
    public float y;
    public float z;

    void Update()
    {
        transform.position = new Vector3(x, y + Mathf.Sin(Time.time) * Amp, z);
    }
}
