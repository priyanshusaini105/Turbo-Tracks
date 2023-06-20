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
    private CoinsManager coinsManager;
    private int thisGameCoins = 0;
    public GameObject gameOverSoundObject;
    public AudioSource gameOverSoundSource;

    private void Start()
    {
        coinsManager = FindObjectOfType<CoinsManager>();
        totalCoins = PlayerPrefs.GetInt("TotalCoins", 0);
        gameOverSoundObject= GameObject.FindGameObjectWithTag("GameOverSound");
        gameOverSoundSource = gameOverSoundObject.GetComponent<AudioSource>();
        Debug.Log("Total Coins: " + totalCoins);
    }

    void Update()
    {
        // Update logic if needed
    }

    public void Play()
    {
        SceneManager.LoadScene("Main");
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }

    public void LoadScene(string sceneName)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }

    public void GameOver()
    {
        if (gameOverPanel != null)
        {
            gameOverSoundSource.Play();
            thisGameCoins = coinsManager.GetCoinsCount();
            PlayerPrefs.SetInt("TotalCoins", totalCoins + thisGameCoins);
            gameOverPanel.SetActive(true);
            gameOverPanel.GetComponent<Animator>().Play("GameOverAnimation");
        }
    }
}
