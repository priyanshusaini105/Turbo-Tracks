using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsController : MonoBehaviour
{
    private CoinsManager coinsManager;
    // public TextMeshProUGUI coinsText;

    void Start()
    {
        coinsManager = FindObjectOfType<CoinsManager>();
        // coinsText = GameObject.FindGameObjectWithTag("CoinsText").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            coinsManager.AddCoin();
            // coinsText.text = coinsManager.GetCoinsCount().ToString();
            Destroy(gameObject);
        }
    }
}
