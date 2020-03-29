using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject EnemyDeath;
    public void TakeDamage(int damage) {
        health -= damage;

        if(health <= 0) {
            Die();
        }
    }

    void Die() {
        Instantiate(EnemyDeath, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
