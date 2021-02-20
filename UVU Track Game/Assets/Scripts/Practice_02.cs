using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_02 : MonoBehaviour
{
    public class EnableComponents : MonoBehaviour
    {
        private Light myLight;

            void Start()
            {
                myLight = GetComponent<Light>();
            }

        void Update()
        {
            if(Input.GetKeyUp(KeyCode.Space))
            {
                myLight.enabled = !myLight.enabled;
            }
        }
    }
    public class CheckState : MonoBehaviour
    {
        public GameObject myObject;
    
    
        void Start ()
        {
            Debug.Log("Active Self: " + myObject.activeSelf);
            Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
        }
    }

    public class TransformFunctions : MonoBehaviour
    {
        public float moveSpeed = 10f;
        public float turnSpeed = 50f;
            
        void Update ()
        {
            if (Input.GetKey(KeyCode.UpArrow))
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.DownArrow))
                transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }
    }
    public class CameraLookAt : MonoBehaviour
    {
        public Transform target;
    
        void Update ()
        {
            transform.LookAt(target);
        }
    }
    public class DestroyBasic : MonoBehaviour
    {
        void Update ()
        {
            if(Input.GetKey(KeyCode.Space))
            {
                Destroy(gameObject);
            }
        }
    }
}