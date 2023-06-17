using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int currentLane = 1;
    public float laneDistance = 4f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        MoveForward();
    }

    private void Update()
    {
        if (SwipeInput.swipedRight)
        {
            Debug.Log("Swiped right");
            if (currentLane < 2)
                MoveToLane(currentLane + 1);
        }
        else if (SwipeInput.swipedLeft)
        {
            Debug.Log("Swiped left");
            if (currentLane > 0)
                MoveToLane(currentLane - 1);
        }
        else if (SwipeInput.swipedUp)
        {
            Debug.Log("Swiped up");
        }
        else if (SwipeInput.swipedDown)
        {
            Debug.Log("Swiped down");
        }
    }

    private void MoveForward()
    {
        rb.velocity = new Vector3(0f, 0f, moveSpeed);
    }

    private void MoveToLane(int lane)
    {
        if (currentLane == lane)
        {
            Debug.Log("Already in lane " + lane);
            return;
        }
        
        float x = (lane - 1) * laneDistance;
        // move to lane
        rb.position = new Vector3(x, rb.position.y, rb.position.z);
        currentLane = lane;
    }
}
