
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFollow : MonoBehaviour
{

    CharacterController _controller;
    Transform target;
    public GameObject Player,Zombie;

    [SerializeField]
    float _moveSpeed = 5.0f;


    // Use this for initialization
    void Start()
    {


        Player = GameObject.FindWithTag("Player");
        target = Player.transform;
        

        _controller = GetComponent<CharacterController>();


    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = target.position - transform.position;

        direction = direction.normalized;

        Vector2 velocity = direction * _moveSpeed;

        _controller.Move(velocity * Time.deltaTime);


    }
}