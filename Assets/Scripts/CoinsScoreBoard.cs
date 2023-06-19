using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinsScoreBoard : MonoBehaviour
{
    // Start is called before the first frame update
    private TMP_Text text;
    private CoinsManager coinsManager;


    void Start()
    {
        text=GetComponent<TMP_Text>();
        coinsManager=FindObjectOfType<CoinsManager>();
        text.text=coinsManager.GetCoinsCount().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
