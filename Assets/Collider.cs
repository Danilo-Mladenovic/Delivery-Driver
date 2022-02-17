using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("AYYO!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Got the juice!");
    }
}
