using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBehaviour : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(-2, 9, 0);

    private void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
