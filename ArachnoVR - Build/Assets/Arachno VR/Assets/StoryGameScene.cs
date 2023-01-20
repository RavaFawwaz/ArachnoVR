using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryGameScene : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("Story Game", LoadSceneMode.Single);
    }
}
