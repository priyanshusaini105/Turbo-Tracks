using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesManager : MonoBehaviour
{
    public GameObject[] obstacles;
    public Transform playerTransform;
    public float spawnZ = 10f;
    public float safeZone = 20f;
    public int obstaclesOnScreen = 5;
    public float obstacleLength = 10f;
    public float spawnX = 4f;

    private List<GameObject> activeObstacles;

    // Start is called before the first frame update
    void Start()
    {
        activeObstacles = new List<GameObject>();

        for (int i = 0; i < obstaclesOnScreen; i++)
        {
            SpawnObstacle();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z - safeZone > (spawnZ - obstaclesOnScreen * obstacleLength))
        {
            SpawnObstacle();
            DeleteObstacle();
        }
    }

    private void SpawnObstacle(int prefabIndex = -1)
    {
        GameObject obstacle;
        obstacle = Instantiate(obstacles[RandomPrefabIndex()]) as GameObject;
        obstacle.transform.SetParent(transform);
        obstacle.transform.position = new Vector3(Random.Range(-spawnX, spawnX), 0.5f, spawnZ);
        spawnZ += obstacleLength;
        activeObstacles.Add(obstacle);
    }

    private void DeleteObstacle()
    {
        Destroy(activeObstacles[0]);
        activeObstacles.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if (obstacles.Length <= 1)
            return 0;

        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, obstacles.Length);
        }

        lastPrefabIndex = randomIndex;
        return randomIndex;
    }

    private int lastPrefabIndex = 0;



}
