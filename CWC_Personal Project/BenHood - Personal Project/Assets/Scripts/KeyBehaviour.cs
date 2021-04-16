using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{
    [SerializeField] private TouchScreenKeyboardType keyType;

    public enum KeyType
    {
        Red,
        Green,
        Blue
    }

    public KeyType GetKeyType()
    {
        return (KeyType) keyType;
    }

    public static Color GetColor(KeyType keyType)
    {
        switch (keyType)
        {
            default:
                case KeyType.Red:  return Color.red;
                case KeyType.Green: return Color.green;
                case KeyType.Blue: return Color.blue;
        }
    }

    private void Update()
    {
        transform.Rotate(0f,2f,0f);

    }
    
}
