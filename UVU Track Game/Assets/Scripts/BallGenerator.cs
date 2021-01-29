using System.Collections;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    private int number = 0;
    public GameObject ball;

    IEnumerator Start()
    {
        while (number < 25)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(ball);
            number++;
        }

    
    }
}    