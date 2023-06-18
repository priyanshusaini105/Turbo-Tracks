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
        Run();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jump()
    {
        animator.SetBool("isJumping", true);
    }

    public IEnumerator Slide()
    {
        animator.SetBool("isSliding", true);
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("isSliding", false);
    }

    public IEnumerator Death()
    {
        animator.SetBool("isDead", true);
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("isDead", false);
    }

    public IEnumerator Victory()
    {
        animator.SetBool("isVictory", true);
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("isVictory", false);
    }

    public IEnumerator Idle()
    {
        animator.SetBool("isIdle", true);
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("isIdle", false);
    }

    public void Run()
    {
        animator.SetBool("isRunning", true);
    }
}
