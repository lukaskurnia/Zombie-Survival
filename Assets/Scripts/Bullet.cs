using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float sp = 5f;
    public int shootDamage = 25;
    public Rigidbody2D rb;
    public GameObject explode;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * sp;
    }

    private void OnTriggerEnter2D(Collider2D info) {
        Debug.Log(info);  
        Enemy enemy = info.GetComponent<Enemy>();
        if(enemy != null) //hit an enemy
            enemy.TakeDamage(shootDamage);

        GameObject _explode = (GameObject)Instantiate(explode, transform.position, transform.rotation);
        Destroy(_explode,0.2f);
        Destroy(gameObject);
    
    }
    
}
