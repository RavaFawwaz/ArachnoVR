using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    int score = 15;
    int damaged = 0;
    public int health;
    public Text ScoreDisplay;
    public Text HealthDisplay;
    public GameObject UICongrats;
    public GameObject UIFail;
    public GameObject UIClear1;
    public GameObject UIClear2;
    public GameObject AllEnemy;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {

    }

    public void AddPoint()
    {
        score -= 1;
    }
    public void Attacked()
    {
        damaged -= 1;
        health -= 1;
    }
    public void Update()
    {
        if (score + damaged <= 0)
        {
            if (score >= 3)
            {
                UIClear1.SetActive(true);
            }
            else if (score >= 1)
            {
                UIClear2.SetActive(true);
            }
            else
            {
                UICongrats.SetActive(true);
            }
        }
        else
        {
            if (health <= 0)
            {
                UIFail.SetActive(true);
                AllEnemy.SetActive(false);
            }
        }
        ScoreDisplay.text = score.ToString();
        HealthDisplay.text = health.ToString();
    }
}