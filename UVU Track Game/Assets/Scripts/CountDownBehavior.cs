using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownBehavior : MonoBehaviour
{
    public int number = 3;
    public float holdTime = 1f;
    public Text countDownText;

    private WaitForSeconds wfsObj;
    
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(holdTime);

        while (number > 0)
        {
            countDownText.text = number.ToString();
            number--;
            yield return wfsObj;
        }

        countDownText.text = "Go!";

        yield return wfsObj;

        countDownText.text = null;
    }
    
}
