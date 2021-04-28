using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private KeyType keyType;

    public enum KeyType
    {
        Magenta,
        Yellow,
        Blue
    }

    public KeyType GetKeyType()
    {
        return keyType;
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0f,100f,0f) * Time.deltaTime);
    }
}
