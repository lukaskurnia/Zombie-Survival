using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float sp = 5f;
    public int shootDamage = 25;
    public Rigidbody2D rb;
    public GameObject explode;

    void Start()
    {
        rb.velocity = transform.right * sp;
    }

    private void OnTriggerEnter2D(Collider2D info) {
        Enemy enemy = info.GetComponent<Enemy>();
        if(enemy != null) //hit an enemy
            enemy.TakeDamage(shootDamage);

        Instantiate(explode, transform.position, transform.rotation);
        Destroy(gameObject);
    
    }
    
}
