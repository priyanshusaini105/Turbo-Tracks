using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsController : MonoBehaviour
{
    private CoinsManager coinsManager;
    public GameObject soundObject;
    private AudioSource sound;
    // public TextMeshProUGUI coinsText;

    void Start()
    {
        coinsManager = FindObjectOfType<CoinsManager>();
        soundObject = GameObject.FindGameObjectWithTag("CoinSound");
        sound = soundObject.GetComponent<AudioSource>();
        // coinsText = GameObject.FindGameObjectWithTag("CoinsText").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            coinsManager.AddCoin();
            // coinsText.text = coinsManager.GetCoinsCount().ToString();
            sound.Play();
            Destroy(gameObject);
        }
    }
}
