using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditMovement : MonoBehaviour
{
    public float degreePerSecond = 15f;
    public float amplitude = 0.5f;
    public float frequency = 1f;

    private Vector3 posOffset = new Vector3();
    private Vector3 temPos = new Vector3();
    
        void Start ()
        //Starting position and rotation of the object
        {
            posOffset = transform.position;
        }

    void Update()
        //Spin credit (dimond) around the Yaxis
    {
        transform.Rotate(new Vector2 (0f, 100f) * Time.deltaTime); 
        
        // Credit Movement vertical
        temPos = posOffset;
        temPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = temPos;
    }
}
