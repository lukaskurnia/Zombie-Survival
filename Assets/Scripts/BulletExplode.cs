using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletExplode : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroyExplosion());
    }

    IEnumerator DestroyExplosion() {
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}
