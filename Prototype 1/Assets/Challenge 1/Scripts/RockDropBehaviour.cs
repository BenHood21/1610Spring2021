using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDropBehaviour : MonoBehaviour
{
    public GameObject target;

    private Vector3 movement;
    public float gravity;
    void Start()
    {
        Invoke ("DropRock", 2);
    }
    
    void DropRock()
    {
        float x = Random.Range(-8.0f, 8.0f);
        float z = Random.Range(-10.0f, 190.0f);
        Instantiate(target, new Vector3(x, 20, z), Quaternion.identity);
        movement.y = gravity * Time.deltaTime; 
    }
}
