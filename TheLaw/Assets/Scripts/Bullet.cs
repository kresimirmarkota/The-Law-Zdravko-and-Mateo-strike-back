using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
    //public GameObject hitEffect;
    private void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        
    }

    private void Update()
    {
        Destroy(gameObject, 1f);
    }

}
