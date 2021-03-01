using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

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

        public class DatatypeScript : MonoBehaviour
        {
            private void Start()
            {
                Vector3 pos = transform.position;
                pos = new Vector3(0, 2, 0);

                Transform tran = transform;
                tran.position = new Vector3(0, 2, 0);
            }
        }

        public class SingleCharacterScript: MonoBehaviour
        {
            public class Stuff
            {
                public int sword;
                public int spear;
                public int shield;

                public Stuff(int swo, int spe, int shi)
                {
                    sword = swo;
                    spear = spe;
                    shield = shi;
                }
            }

            public Stuff myStuff = new Stuff(10, 7, 25);
            public float speed;
            public float turnSpeed;
            public Rigidbody2D spearPrefab;
            public Transform firePosition;
            public float spearSpeed;

            private void Update()
            {
                Movement();
                Shoot();
            }

            private void Movement()
            {
                float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
                float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
                
                transform.Translate(Vector3.forward * forwardMovement);
                transform.Rotate(Vector3.up * turnMovement);
            }

            void Shoot()
            {
                if (Input.GetButtonDown("Fire1") && myStuff.spear > 0)
                {
                    Rigidbody2D spearInstance = Instantiate(spearPrefab, firePosition.position, firePosition.rotation);
                    spearInstance.AddForce(firePosition.forward * spearSpeed);
                    myStuff.spear--;
                }
            }
            // Switch practice

            static void Main(string[] args)
            {
                int song = 5;
                switch (song)
                {
                    case 1 :
                        Console.WriteLine("Lean Wit Me");
                        break;
                    case 2 :
                        Console.WriteLine("Clout Cobain");
                        break;
                    case 3 :
                        Console.WriteLine("The Box");
                        break;
                    case 4 :
                        Console.WriteLine("G.O.M.D");
                        break;
                    case 5 :
                        Console.WriteLine("Psycho");
                        break;
                    case 6 :
                        Console.WriteLine("Scared of the Dark");
                        break;
                    case 7 :
                        Console.WriteLine("Wizard of Oz");
                        break;
                }
            }

            public class InvokeRepeating : MonoBehaviour
            {
                public GameObject target;


                void Start()
                {
                    InvokeRepeating("SpawnObject", 2, 1 / 2);
                    CancelInvoke("SpawnObject");
                }

                void SpawnObject()
                {
                    float x = UnityEngine.Random.Range(-2.0f, 2.0f);
                    float z = UnityEngine.Random.Range(-2.0f, 2.0f);
                    Instantiate(target, new Vector3(x, 2, z), Quaternion.identity);
                }
            }
            
            public class EnumScript : MonoBehaviour 
            {
                enum Direction {North, East, South, West};

                void Start () 
                {
                    Direction myDirection;
        
                    myDirection = Direction.North;
                }
    
                Direction ReverseDirection (Direction dir)
                {
                    if(dir == Direction.North)
                        dir = Direction.South;
                    else if(dir == Direction.South)
                        dir = Direction.North;
                    else if(dir == Direction.East)
                        dir = Direction.West;
                    else if(dir == Direction.West)
                        dir = Direction.East;
        
                    return dir;     
                }
            }
        }
    }
}

