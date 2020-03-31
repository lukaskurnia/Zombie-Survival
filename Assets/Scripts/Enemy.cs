using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public static int numOfEnemies = 0;
    public int health = 100;
    private const int scoreValue = 100;
    public GameObject EnemyDeath;

    //Movement
    private float speed = 0.8f;
    private bool facingRight = true;

    private Animator animator;
    private Rigidbody2D rigidBody;

    private void Awake() {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Update() { 
        if(rigidBody.velocity.y == 0) {            
            animator.SetBool("isWalking", true);
            animator.SetBool("isAttack", false);
        }     
        transform.Translate(2 * Time.deltaTime * speed, 0.0f,0.0f);
    }

    private void OnTriggerEnter2D(Collider2D info) {
        if(info.gameObject.CompareTag("turn_back") || info.gameObject.CompareTag("zombie")){
            Flip();
        }
    }

    private void OnTriggerStay2D(Collider2D info) {
        PlayerController player = info.GetComponent<PlayerController>();
        if(player != null){ //hit an enemy
            animator.SetBool("isAttack", true);
            animator.SetBool("isWalking", false);
        }                    
    }

    private void Flip() {
        facingRight = !facingRight;
        transform.Rotate(0f,180f,0f);
    }

    public void TakeDamage(int damage) {
        health -= damage;

        if(health <= 0) {
            Die();
        }
    }

    void Die() {
        Instantiate(EnemyDeath, transform.position, Quaternion.identity);
        Score.score += scoreValue;
        numOfEnemies--;
        Destroy(gameObject);
    }

}
