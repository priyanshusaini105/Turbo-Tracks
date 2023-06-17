using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int currentLane = 1;
    public float laneDistance = 4f;
    public float jumpForce = 5f;

    private Rigidbody rb;
    private bool hasJumped = false;

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
            if (!hasJumped)
                Jump();
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

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        hasJumped = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            hasJumped = false;
        }
    }
}
