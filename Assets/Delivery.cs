using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool pickedPackage = false;
    [SerializeField] float destroyTimer = 0.5f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("AYYO!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            if (!pickedPackage)
            {
                Debug.Log("Got the juice!");
                pickedPackage = true;
                Destroy(other.gameObject, destroyTimer);
            }
            else
            {
                Debug.Log("You already have the juice.");
            }
        }
        else if (other.tag == "Drop")
        {
            if (pickedPackage)
            {
                Debug.Log("Prime delivery!");
                pickedPackage = false;
            }
            else
            {
                Debug.Log("You don't have the juice.");
            }

        }
    }
}
