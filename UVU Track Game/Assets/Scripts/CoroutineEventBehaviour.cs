using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineEventBehaviour : MonoBehaviour
{
  public UnityEvent startEvent;
  public int number, maxNumber;
  public float holdTime = 1f;
  private WaitForSeconds wfsObj;

  private IEnumerator Start()
  {
    wfsObj = new WaitForSeconds(holdTime);

    while (number < maxNumber)
      {
        startEvent.Invoke();
        yield return wfsObj;
        number++;
      }
  }
}
