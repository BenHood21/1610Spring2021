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


}