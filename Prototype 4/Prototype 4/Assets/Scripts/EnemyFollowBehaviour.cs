using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowBehaviour : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;

    private void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }
}
