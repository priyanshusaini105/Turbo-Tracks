using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetController : MonoBehaviour
{
    public float roadPlaneLength = 100f;
    public GameObject roadPlanePrefab;
    public GameObject currentRoadPlane;
    public GameObject nextRoadPlane;

    private GameObject player;
    // private bool isRoadPlaneSpawned = false;

    private void Start()
    {
        player = GameObject.Find("Player");
        // Instantiate the initial road plane
        currentRoadPlane = Instantiate(roadPlanePrefab, Vector3.zero, Quaternion.identity);
        nextRoadPlane = Instantiate(roadPlanePrefab, new Vector3(0, 0, roadPlaneLength), Quaternion.identity);
    }

    private void Update()
    {
        SpawnNextRoadPlane();
    }

    private void SpawnNextRoadPlane()
    {
        if (nextRoadPlane != null && player != null && player.transform.position.z >= nextRoadPlane.transform.position.z-roadPlaneLength/2 )
        {
            Destroy(currentRoadPlane);
            currentRoadPlane = nextRoadPlane;
            nextRoadPlane = Instantiate(roadPlanePrefab, new Vector3(0, 0, currentRoadPlane.transform.position.z + roadPlaneLength), Quaternion.identity);
            // isRoadPlaneSpawned = true;
        }
    }
}
