using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetArrow : MonoBehaviour
{
    public Transform ArrowPoint;
    public GameObject Arrows;

    public void ButtonClicked()
    {
        Arrows.transform.position = ArrowPoint.transform.position;
    }
}
