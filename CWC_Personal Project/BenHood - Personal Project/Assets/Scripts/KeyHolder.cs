using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
   private List<Key.KeyType> keyList;

   private void Awake()
   {
      keyList = new List<Key.KeyType>();
   }

   private void AddKey(Key.KeyType keyType)
   {
      Debug.Log("Added Key: " + keyType);
      keyList.Add(keyType);
   }
   private void RemoveKey(Key.KeyType keyType)
   {
      keyList.Remove(keyType);
   }
   private bool ContainsKey(Key.KeyType keyType)
   {
      return keyList.Contains(keyType);
   }

   private void OnTriggerEnter(Collider collider)
   {
      Key key = collider.GetComponent<Key>();
      if (key != null)
      {
         AddKey(key.GetKeyType());
         Destroy(key.gameObject);
      }

      KeyDoor keyDoor = collider.GetComponent<KeyDoor>();
      if (keyDoor != null)
      {
         if (ContainsKey(keyDoor.GetKeyType()))
         {
            RemoveKey(keyDoor.GetKeyType());
            keyDoor.OpenDoor();  
         }
      }
   }
}
