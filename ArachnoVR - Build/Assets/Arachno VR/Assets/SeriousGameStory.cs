using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeriousGameStory : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("Tutorial Stage", LoadSceneMode.Single);
    }
}
