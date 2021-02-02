using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{
			GetComponent<Renderer> ().material.color = Color.red;
		}
		if (Input.GetKeyDown(KeyCode.G))
		{
			GetComponent<Renderer>().material.color = Color.green;
		}
		if (Input.GetKeyDown(KeyCode.B))
		{
			GetComponent<Renderer>().material.color = Color.blue;
		}
		
	}
	
		public class ScopeAndAccessModifiers : MonoBehaviour
		{
			public int alpha = 5;
			
			private int beta = 0;
			private int gamma = 5;
			
			private AnotherClass myOtherClass;

			void Start ()
			{
				alpha = 29;

				myOtherClass = new AnotherClass();
				myOtherClass.FruitMachine(alpha, myOtherClass.apples);
			}
			
			void Example (int pens, int crayons)
			{
				int answer;
				answer = pens * crayons * alpha;
				Debug.Log(answer);
			}
				
			void Update ()
			{
				Debug.Log("Alpha is set to: " + alpha);
			}
		}
		
		public class AnotherClass
		{
			public int apples;
			public int bananas;
			
			private int stapler;
			private int sellotape;
			
			public void FruitMachine (int a, int b)
			{
				int answer;
				answer = a + b;
				Debug.Log ("fruit total: " + answer);
			}
			
			private void OfficeSort (int a, int b)
			{
				int answer;
				answer = a + b;
				Debug.Log("Office Supplies total: " + answer);
			}
		}
}