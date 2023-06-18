using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Jump()
    {
        animator.SetBool("isJumping", true);
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("isJumping", false);
    }
}
