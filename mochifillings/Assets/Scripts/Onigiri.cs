using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onigiri : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // play sound then dissappear 
            // maybe countdown UI 
            Destroy(gameObject);
        }
    }
}
