using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Counter : MonoBehaviour
{
	public int creditValue = 3;
	public IntData numberCount;
	public Text counterText;

	private void Start()
	{
	 	counterText.text = numberCount.value.ToString();
	}

	
   void OnTriggerEnter2D(Collider2D col)
   {
	   numberCount.value += creditValue;
	   counterText.text = numberCount.value.ToString();
		// Non-trigger on Bullet
	   if (col.gameObject.name.Equals("Bullet"))
	   {
		   gameObject.SetActive(true);   
	   }
		// Trigger on BB8
	   if (col.gameObject.name.Equals("Wheel"))
	   {
		   gameObject.SetActive(false);
	   }
   }
}