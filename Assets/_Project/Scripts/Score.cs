using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Action OnBalloonClicked;
    
    private int _score;
    private TextMeshProUGUI _text;
    
    private void OnEnable()
    {
        OnBalloonClicked += AddScore;
    }
    
    private void OnDisable()
    {
        OnBalloonClicked -= AddScore;
    }

    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        _text.SetText("Score: " + _score);
    }

    private void AddScore()
    {
        _score++;
        _text.SetText("Score: " + _score);
    }
}
