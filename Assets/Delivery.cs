using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool pickedPackage = false;
    [SerializeField] float destroyTimer = 0.5f;

    [SerializeField] Color32 driverWithPackage = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 driverWithoutPackage = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

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
                spriteRenderer.color = driverWithPackage;
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
                spriteRenderer.color = driverWithoutPackage;
            }
            else
            {
                Debug.Log("You don't have the juice.");
            }

        }
    }
}
