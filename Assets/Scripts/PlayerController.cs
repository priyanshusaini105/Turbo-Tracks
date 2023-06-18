using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int currentLane = 1;
    public float laneDistance = 4f;
    public float jumpForce = 5f;

    private Rigidbody rb;
    private bool hasJumped = false;
    // private CharacterController controller;
    private PlayerAnimationController playerAnimationController;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        // controller = GetComponent<CharacterController>();
        playerAnimationController = GetComponent<PlayerAnimationController>();

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
            if (!hasJumped){
                playerAnimationController.Jump();
                Jump();
            }
        }
        else if (SwipeInput.swipedDown)
        {
            Debug.Log("Swiped down");
        }

        // if grounded set hasJumped to false
        // if (controller.isGrounded)
        // {
        //     hasJumped = false;
        // }

        // Debug.Log(controller.isGrounded);
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

    // set jump to false
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            hasJumped = false;
        }
    }

}
