using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletExplode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Destroy(gameObject);
        StartCoroutine(DestroyExplosion());
    }

    IEnumerator DestroyExplosion() {
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}
