using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyBehaviour : MonoBehaviour
{
   public Transform destination;
   public NavMeshAgent agent;

   private void Start()
   {
      agent = GetComponent<NavMeshAgent>();
      destination = transform;
   }

   private void OnTriggerEnter(Collider other)
   {
      destination = other.transform;
   }

   private void OnTriggerExit(Collider other)
   {
      destination = transform;
   }

   private void Update()
   {
      agent.destination = destination.position;
   }
}
