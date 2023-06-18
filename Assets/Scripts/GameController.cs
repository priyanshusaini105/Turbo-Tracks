using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerAnimationController playerAnimationController;
    public GameObject player;
    // public ObstaclesManager obstaclesManager;
    // public StreetController streetController;
    // public GameObject gameOverPanel;
    // public GameObject victoryPanel;
    // public GameObject startPanel;
    // public GameObject pausePanel;
    // public GameObject scorePanel;
    // public GameObject scoreText;
    // public GameObject highScoreText;
    // public GameObject scoreTextGameOver;
    // public GameObject highScoreTextGameOver;
    // public GameObject scoreTextVictory;
    // public GameObject highScoreTextVictory;
    // public GameObject scoreTextPause;

    // private bool isGameOver = false;
    // private bool isVictory = false;
    // private bool isGameStarted = false;
    // private bool isGamePaused = false;
    // private bool isScorePanelActive = false;
    // private bool isHighScorePanelActive = false;
    // private bool isScoreTextActive = false;
    // private bool isHighScoreTextActive = false;
    // private bool isScoreTextGameOverActive = false;
    // private bool isHighScoreTextGameOverActive = false;
    // private bool isScoreTextVictoryActive = false;
    // private bool isHighScoreTextVictoryActive = false;
    // private bool isScoreTextPauseActive = false;

    // private float score = 0f;
    // private float highScore = 0f;

    private void Start()
    {
        // Time.timeScale = 0;

        // highScore = PlayerPrefs.GetFloat("highScore", 0f);
        // highScoreText.GetComponent<UnityEngine.UI.Text>().text = "High Score: " + highScore.ToString("0");
        // highScoreTextGameOver.GetComponent<UnityEngine.UI.Text>().text = "High Score: " + highScore.ToString("0");
        // highScoreTextVictory.GetComponent<UnityEngine.UI.Text>().text = "High Score: " + highScore.ToString("0");

        playerAnimationController = player.GetComponent<PlayerAnimationController>();
        playerAnimationController.Run();
    }
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(playerAnimationController.GetIsRunnig());
    }
}
