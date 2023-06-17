using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetController : MonoBehaviour
{
    public float roadPlaneLength = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // spwan the next tile while player enters the current tile
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the tile");
            // spawn the next tile
            Vector3 spawnPos = new Vector3(0f, 0f, transform.position.z + roadPlaneLength);
            Instantiate(gameObject, spawnPos, Quaternion.identity);
            // destroy the current tile
            Destroy(gameObject);
        }
    }

}
