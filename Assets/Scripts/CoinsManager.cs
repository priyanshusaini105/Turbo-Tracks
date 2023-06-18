using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    public GameObject[] coins;
    public Transform playerTransform;
    public float spawnZ = 10f;
    public float safeZone = 20f;
    public int coinsOnScreen = 5;
    public float coinLength = 10f;
    public float spawnX = 4f;

    private List<GameObject> activeCoins;

    // Start is called before the first frame update
    void Start()
    {
        activeCoins = new List<GameObject>();

        for (int i = 0; i < coinsOnScreen; i++)
        {
            SpawnCoin();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z - safeZone > (spawnZ - coinsOnScreen * coinLength))
        {
            SpawnCoin();
            DeleteCoin();
        }
    }

    private void SpawnCoin(int prefabIndex = -1)
    {
        GameObject coin;
        coin = Instantiate(coins[RandomPrefabIndex()]) as GameObject;
        coin.transform.SetParent(transform);
        coin.transform.position = new Vector3(Random.Range(-spawnX, spawnX), 0.5f, spawnZ);
        spawnZ += coinLength;
        activeCoins.Add(coin);
    }

    private void DeleteCoin()
    {
        Destroy(activeCoins[0]);
        activeCoins.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if (coins.Length <= 1)
            return 0;

        int randomIndex = Random.Range(0, coins.Length);

        return randomIndex;
    }
}
