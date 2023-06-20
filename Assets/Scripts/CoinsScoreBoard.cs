using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class CoinsScoreBoard : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProUGUI text;


    void Start()
    {
        text=GetComponent<TextMeshProUGUI>();
        text.text=PlayerPrefs.GetInt("TotalCoins",0).ToString();
    }
}
