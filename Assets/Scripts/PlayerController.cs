using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private Rigidbody2D rigidBody;
    private Animator animator;
    
    // For moving character
    private float moveSpeed;
    private float dirX;

    //For flip character
    private bool facingRight = true;
    private Vector3 localScale;

    private const float ERROR = 0.001f;

    // Start is called before the first frame update
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        localScale = transform.localScale;
        moveSpeed = 5f;
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        // print(dirX);

        //Handle Jump
        if(Input.GetButtonDown("Jump") && rigidBody.velocity.y >= -ERROR && rigidBody.velocity.y <= ERROR) {
            rigidBody.AddForce(Vector2.up * 700f);
        }

        //Handle Run
        if(Mathf.Abs(dirX) > 0 && rigidBody.velocity.y >= -ERROR && rigidBody.velocity.y <= ERROR) {
            animator.SetBool("isRunning", true);
        }
        else {
            animator.SetBool("isRunning", false);
        }

        if(rigidBody.velocity.y >= -ERROR && rigidBody.velocity.y <= ERROR) {
            animator.SetBool("isJumping", false);
            animator.SetBool("isFalling", false);
        }

        if(rigidBody.velocity.y > ERROR) {
            animator.SetBool("isJumping", true);            
        }

        if(rigidBody.velocity.y < -ERROR) {
            animator.SetBool("isJumping", false);
            animator.SetBool("isFalling", true);
        }
    }

    private void FixedUpdate() {
        rigidBody.velocity = new Vector2(dirX, rigidBody.velocity.y);
        Debug.Log(rigidBody.velocity.x);
        Debug.Log(rigidBody.velocity.y);
    }

    private void LateUpdate() {
        if(dirX > 0) {
            facingRight = true;
        }
        else if (dirX < 0) {
            facingRight = false;
        }

        if((facingRight && localScale.x < 0) || (!facingRight && localScale.x > 0) ) {
            localScale.x *= -1;
        }

        transform.localScale = localScale;
    }
}
