using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed;
    private Transform target;
    private AudioSource hitSound;
    
    Transform heroTransform,zombieTransform;

    // Start is called before the first frame update
    void Start()
    {
        hitSound = GetComponent<AudioSource>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    void destroyGameObject()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag=="Bullet")
        {

            hitSound.Play();

            Invoke("destroyGameObject", 0.3f);


        }
        
    }
    // Update is called once per frame
 
    
}
