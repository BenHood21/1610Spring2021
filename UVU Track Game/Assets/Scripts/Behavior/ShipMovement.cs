using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float min=-10f;
    public float max=10f;
    
    void Start () 
    {
       
        min=transform.position.x - 10;
        max=transform.position.x + 10;
   
    }
   
    // Update is called once per frame
    void Update () 
    {
        transform.position =new Vector3(Mathf.PingPong(Time.time*2,max-min)+min, transform.position.y);
       
    }
}