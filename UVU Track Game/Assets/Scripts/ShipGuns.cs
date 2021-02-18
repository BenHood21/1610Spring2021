using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipGuns : MonoBehaviour
{
 
    public float fireRate;
    public float nextFire;
  
    //Bullet collision trigger
    public Transform firePoint;
    public GameObject bullet;
    private int number = 0;

    IEnumerator Start()
    {
        while (number < 4)
        {
            fireRate = 1f;
            yield return new WaitForSeconds(1f);
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }
    }
}