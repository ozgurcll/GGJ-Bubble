using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager instance;
    public TextMeshProUGUI score_text;
    
    void Start()
    {
        instance = this;
        Time.timeScale = 1;
    }
    public void UpdateScore()
    {
        score++;
        score_text.text = score.ToString();
     
    }
    
    void Update()
    {
        if (score ==20)
        {
            SceneManager.LoadScene(3);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(2);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
