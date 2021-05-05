using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_SpawnBehaviour : MonoBehaviour
{
    public float fireRate;
    public float nextFire;
  
    //Bullet collision trigger
    public Transform firePoint;
    public GameObject bullet;
    private int number = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        { 
            while (number < 4);
            fireRate = 1f;
            //yield return new WaitForSeconds(1f);
            Instantiate(bullet, firePoint.position, firePoint.rotation);
          Debug.Log("Aim Player");
          
        }
    }

    IEnumerator BulletRate()
    {
        while (number < 4);
        fireRate = 1f;
        yield return new WaitForSeconds(1f);
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}