using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Speed
    public float fallSpeed;
    public float maxFallSpeed;

    //Score
    public string scoreText;
    GameObject text;
    TextMeshProUGUI score;
    int currentScore = 0;

    //GameOver
    public TextMeshProUGUI gameOverText;
    public bool isGameActive =  true;
    public Button restartButton;

    //Start game
    public GameObject titleScreen;
 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Increase meteor speed over time
        if (fallSpeed < maxFallSpeed) 
        {
            fallSpeed += 0.1f * Time.deltaTime;

        }
    }

    public void UpdateScore(int i)
    {
        currentScore = currentScore + i;
        score.text = "Score: " + currentScore;
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void StartGame() 
    {
        isGameActive = true;
        titleScreen.gameObject.SetActive(false);
        text = GameObject.Find("Score");
        score = text.GetComponent<TextMeshProUGUI>();
        score.text = "Score: " + currentScore;
    }

}
