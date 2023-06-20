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
    private SwipeInput swipeInput; // Add a reference to the SwipeInput class

    private void Start()
    {
        coinsManager = FindObjectOfType<CoinsManager>();
        totalCoins = PlayerPrefs.GetInt("TotalCoins", 0);
        gameOverSoundObject = GameObject.FindGameObjectWithTag("GameOverSound");
        gameOverSoundSource = gameOverSoundObject.GetComponent<AudioSource>();
        swipeInput = FindObjectOfType<SwipeInput>(); // Assign the reference to the SwipeInput instance
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
        swipeInput.IsDisableSwip(true);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        swipeInput.IsDisableSwip(false);
    }

    public void LoadScene(string sceneName)
    {
        swipeInput.IsDisableSwip(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }

    public void GameOver()
    {
        if (gameOverPanel != null)
        {
            swipeInput.IsDisableSwip(true);
            gameOverSoundSource.Play();
            thisGameCoins = coinsManager.GetCoinsCount();
            PlayerPrefs.SetInt("TotalCoins", totalCoins + thisGameCoins);
            gameOverPanel.SetActive(true);
            gameOverPanel.GetComponent<Animator>().Play("GameOverAnimation");
        }
    }
}
