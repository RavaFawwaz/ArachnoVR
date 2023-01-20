using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnableDisable1 : MonoBehaviour
{
    public GameObject firstTutorial;
    public bool isEnabled = true;

    public void ButtonClicked()
    {
        isEnabled = !isEnabled;
        firstTutorial.SetActive(isEnabled);
    }
}
