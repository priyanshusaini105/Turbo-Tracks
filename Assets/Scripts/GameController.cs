using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private PlayerAnimationController playerAnimationController;
    public GameObject player;
    public GameObject gameOverPanel;
    private int totalCoins = 0;

    private void Start()
    {
        if (player != null)
            playerAnimationController = player.GetComponent<PlayerAnimationController>();

        playerAnimationController.Run();
        totalCoins = PlayerPrefs.GetInt("TotalCoins", 0);
    }

    void Update()
    {
        // Update logic if needed
    }

    public void Play()
    {
        SceneManager.LoadScene("Main");
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
            gameOverPanel.GetComponent<Animator>().Play("GameOverAnimation");
        }
    }
}
