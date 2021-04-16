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
        Gold,
        Green,
        Blue
    }

    public KeyType GetKeyType()
    {
        return keyType;
    }
}
