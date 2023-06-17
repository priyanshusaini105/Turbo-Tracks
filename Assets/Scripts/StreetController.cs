using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetController : MonoBehaviour
{
    public float roadPlaneLength = 100f;
    public GameObject roadPlanePrefab;

    private GameObject player;
    private bool isRoadPlaneSpawned = false;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        if (!isRoadPlaneSpawned)
        {
            SpawnNextRoadPlane();
        }
    }

    private void SpawnNextRoadPlane()
    {
        float playerZ = player.transform.position.z;
        float roadPlaneZ = transform.position.z;
        
        if (playerZ > roadPlaneZ)
        {
            Vector3 nextRoadPlanePosition = new Vector3(0, 0, roadPlaneZ + roadPlaneLength);
            Instantiate(roadPlanePrefab, nextRoadPlanePosition, Quaternion.identity);
            isRoadPlaneSpawned = true;
        }
    }
}
