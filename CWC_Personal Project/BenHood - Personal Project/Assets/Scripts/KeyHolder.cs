using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
   public event EventHandler OnKeysChanged;
   
   private List<Key.KeyType> keyList;

   private void Awake()
   {
      keyList = new List<Key.KeyType>();
   }

   public List<Key.KeyType> GetKeyList()
   {
      return keyList;
   }
   
   private void AddKey(Key.KeyType keyType)
   {
      Debug.Log("Added Key: " + keyType);
      keyList.Add(keyType);
      OnKeysChanged?.Invoke(this,EventArgs.Empty);
   }
   private void RemoveKey(Key.KeyType keyType)
   {
      keyList.Remove(keyType);
      OnKeysChanged?.Invoke(this,EventArgs.Empty);

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
