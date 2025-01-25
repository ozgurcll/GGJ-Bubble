using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI score_text;
    
    void Start()
    {
        
    }
    public void UpdateScore()
    {
        score++;
        score_text.text = score.ToString();
    }
    
    void Update()
    {
        
    }
}
