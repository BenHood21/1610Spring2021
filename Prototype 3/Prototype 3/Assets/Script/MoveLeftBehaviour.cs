using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftBehaviour : MonoBehaviour
{
    private float speed = 20;
    private PlayerControllerBehaviour playerControllerScript;
    private float leftBound = -15;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerBehaviour>();
    }

    private void Update()
    {
            if (playerControllerScript.gameOver == false)
        {
             transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
