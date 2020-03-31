using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZombie : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(DestroyZombie());
    }

    IEnumerator DestroyZombie() {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

}
