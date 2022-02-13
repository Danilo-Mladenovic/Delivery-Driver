using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float starting_angle = -90f;
    [SerializeField] float translation_z = 0.01f;

    void Start()
    {
        transform.Rotate(0, 0, starting_angle);
    }

    void Update()
    {
        // transform.Rotate(0, 0, 1);
        transform.Translate(0, translation_z, 0);
    }
}
