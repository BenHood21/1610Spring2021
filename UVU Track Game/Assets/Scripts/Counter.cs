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

	private void Update ()
	{
		transform.Rotate(new Vector3 (0f, 0f, 100f) * Time.deltaTime);
	}
   void OnTriggerEnter2D()
   {
	   numberCount.value += creditValue;
	   counterText.text = numberCount.value.ToString();
	   gameObject.SetActive(false);
   }
}