using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        MoveForward();
    }

    void Update()
    {
        if (SwipeInput.swipedRight)
        {
            Log("Swiped right");
        }
        else if (SwipeInput.swipedLeft)
        {
            Log("Swiped left");
        }
        else if (SwipeInput.swipedUp)
        {
            Log("Swiped up");
        }
        else if (SwipeInput.swipedDown)
        {
            Log("Swiped down");
        }
    }

    void MoveForward()
    {
        rb.velocity = new Vector3(0f, 0f, moveSpeed);
        Log("Moving forward");
    }

    void Log(string message)
    {
        Debug.Log(message);
    }
}
