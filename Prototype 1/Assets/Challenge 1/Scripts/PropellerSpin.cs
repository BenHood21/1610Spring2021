using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float rotationSpeed;
    
    // Start is called before the first frame update
    void Update()
    {
        transform.Rotate(new Vector3(0,0, Time.deltaTime * rotationSpeed));
    }
}