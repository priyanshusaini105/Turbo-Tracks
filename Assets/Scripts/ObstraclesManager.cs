using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstraclesManager : MonoBehaviour
{
    public GameObject[] obstracles;
    public float obstracleSpawnDistance = 10f;
    public float obstracleSpawnHeight = 0f;
    public float laneDistance = 4f;
    public float obstracleSpawnX = 0f;
    public GameObject currentObstracle;

    private GameObject player;
    private float lastObstracleSpawnZ = 0f;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        lastObstracleSpawnZ = player.transform.position.z;
        obstracleSpawnX = obstracles[0].transform.position.x;     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        SpawnObstracles();
    }

    private void SpawnObstracles()
    {
        // desroy the prevoius obsrcale and genrate new one
        if (player.transform.position.z - lastObstracleSpawnZ > obstracleSpawnDistance)
        {
            Destroy(currentObstracle);
            int randomObstracle = Random.Range(0, obstracles.Length);
            currentObstracle = Instantiate(obstracles[randomObstracle]);
            currentObstracle.transform.position = new Vector3(obstracleSpawnX, obstracleSpawnHeight, player.transform.position.z + obstracleSpawnDistance);
            lastObstracleSpawnZ = player.transform.position.z;
        }
    }

}
