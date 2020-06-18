﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField] private Text Txt_Score = null;
    public static GameManager thisManager = null;
    private int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        thisManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore()
    {
        Score++;
        Txt_Score.text = "SCORE : " + Score;
    }
    private void StartGame()
    {
        Score = 0;
        Txt_Score.text = "SCORE : 0";
    }
}
