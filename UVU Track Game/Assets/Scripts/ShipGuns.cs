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
    public Rigidbody2D bullet;
    private int number = 0;

    IEnumerator Start()
    {
        while (number < 4)
        {
            fireRate = 1f;
            nextFire = Time.time;
            yield return new WaitForSeconds(1f);
            gameObject.SetActive(true);
            bullet = Instantiate(bullet, firePoint.position, firePoint.rotation);
        }
    }

    void Update()
    {
        CheckIfTimeToFire ();
    }

    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
            
        }
    }
    //Bullet Duplication
    
}