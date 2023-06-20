using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SetCurrentScore : MonoBehaviour
{
    public TextMeshProUGUI text;
    public CoinsManager coinsManager;
    // Start is called before the first frame update
    void Start()
    {
        text=GetComponent<TextMeshProUGUI>();
        coinsManager = FindObjectOfType<CoinsManager>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text=coinsManager.GetCoinsCount().ToString();    
    }
}
