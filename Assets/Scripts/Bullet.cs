using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float sp = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * sp;
    }

    private void OnTriggerEnter2D(Collider2D info) {
        Debug.Log(info);        
    }
    
}
