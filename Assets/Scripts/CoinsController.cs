using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsController : MonoBehaviour
{

    private CoinsManager coinsManager;

    // Start is called before the first frame update
    void Start()
    {
        coinsManager = FindObjectOfType<CoinsManager>();      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
                Debug.Log(other.gameObject.tag);
            if (other.gameObject.tag == "Player")
            {
                coinsManager.AddCoin();
                Destroy(gameObject);
            }
    }
}
