using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_03 : MonoBehaviour
{
    //Using Other Components
    public GameObject otherGameObject;
    
    
    private Practice anotherScript;
    private Practice_02 yetAnotherScriPractice02;
    private BoxCollider boxCol;
    
    
    void Awake ()
    {
        anotherScript = GetComponent<Practice>();
        yetAnotherScriPractice02 = otherGameObject.GetComponent<Practice_02>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }
    
    
    void Start ()
    {
        boxCol.size = new Vector3(3,3,3);
        Debug.Log("The player's score is " + anotherScript.gameObject);
        Debug.Log("The player has died " + yetAnotherScriPractice02+ " times");
    }
    
    public class UsingDeltaTime : MonoBehaviour
    {
        public float speed = 8f; 
        public float countdown = 3.0f;

    
        void Update ()
        {
            countdown -= Time.deltaTime;
            if (Input.GetKey(KeyCode.RightArrow))
                transform.position = new Vector2(speed * Time.deltaTime, 0f);
            
        }   
    }
}

