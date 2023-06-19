using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    private int totalCoins=0;

    private void Start()
    {
        // Time.timeScale = 0;

        // highScore = PlayerPrefs.GetFloat("highScore", 0f);
        // highScoreText.GetComponent<UnityEngine.UI.Text>().text = "High Score: " + highScore.ToString("0");
        // highScoreTextGameOver.GetComponent<UnityEngine.UI.Text>().text = "High Score: " + highScore.ToString("0");
        // highScoreTextVictory.GetComponent<UnityEngine.UI.Text>().text = "High Score: " + highScore.ToString("0");
    
        playerAnimationController = player.GetComponent<PlayerAnimationController>();
        playerAnimationController.Run();
        totalCoins=PlayerPrefs.GetInt("TotalCoins",0);
    }
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(playerAnimationController.GetIsRunnig());
    }

    // public void Jump(){
    //     playerAnimationController.Jump();
    // }

    // public void Slide(){
    //     playerAnimationController.Slide();
    // }

    // public void MoveToLane(int lane){
    //     playerAnimationController.MoveToLane(lane);
    // }

    // public void MoveForward(){
    //     playerAnimationController.Run();
    // }
    public void Play(){
        // isGameStarted = true;
        // startPanel.SetActive(false);
        // scorePanel.SetActive(true);
        // scoreText.SetActive(true);
        // highScoreText.SetActive(true);
        // scoreText.GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString("0");
        // highScoreText.GetComponent<UnityEngine.UI.Text>().text = "High Score: " + highScore.ToString("0");
        // Time.timeScale = 1;
        // streetController.StartMoving();
        // obstaclesManager.StartSpawning();
        // playerAnimationController.Run();
        SceneManager.LoadScene("Game");
    }

    public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }


    public void GameOver(){
        // isGameOver = true;
        // gameOverPanel.SetActive(true);
        // scoreTextGameOver.GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString("0");
        // if (score > highScore)
        // {
        //     highScore = score;
        //     PlayerPrefs.SetFloat("highScore", highScore);
        //     highScoreTextGameOver.GetComponent<UnityEngine.UI.Text>().text = "High Score: " + highScore.ToString("0");
        // }
        Debug.Log("Game Over");
        // PlayerPrefs.SetInt("TotalCoins",totalCoins+thisGameCoins);
    }
}
