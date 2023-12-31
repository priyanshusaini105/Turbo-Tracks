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
    public float laneDistance = 2.5f;

    private int coinsCount = 0;

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
        // position on the one of  the 3 lanes
        int lane = Random.Range(0, 3);
        float x=(lane-1)*laneDistance;
        coin.transform.position = new Vector3(x, 1.2f, spawnZ);

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

     public void AddCoin(){
        coinsCount++;
     }

    public int GetCoinsCount(){
        return coinsCount;
    }

    public void ResetCoinsCount(){
        coinsCount = 0;
    }
    public void SetCoinsCount(int count){
        coinsCount = count;
    }

}
