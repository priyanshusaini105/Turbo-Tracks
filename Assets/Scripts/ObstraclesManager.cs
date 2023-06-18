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
        if (player.transform.position.z >= lastObstracleSpawnZ + obstracleSpawnDistance)
        {
            lastObstracleSpawnZ = player.transform.position.z;
            int randomObstracleIndex = Random.Range(0, obstracles.Length);
            int randomLaneIndex = Random.Range(0, 3);
            GameObject obstracle = Instantiate(obstracles[randomObstracleIndex]);
            obstracle.transform.position = new Vector3(obstracleSpawnX + (randomLaneIndex * laneDistance), obstracleSpawnHeight, lastObstracleSpawnZ + obstracleSpawnDistance);
        }
    }

}
