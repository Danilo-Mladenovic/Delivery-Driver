using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    void Start()
    {
        transform.Rotate(0, 0, -90);
    }

    void Update()
    {
        // transform.Rotate(0, 0, 1);
        transform.Translate(0, 0.1f, 0);
    }
}
