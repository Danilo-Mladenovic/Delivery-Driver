using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float startingAngle = -90f;
    [SerializeField] float translationSpeed = 12f;
    [SerializeField] float turningAngle = 256f;

    void Start()
    {

    }

    void Update()
    {
        float rotationAngle = Input.GetAxis("Horizontal") * turningAngle * Time.deltaTime;
        float speed = Input.GetAxis("Vertical") * translationSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -rotationAngle);
        transform.Translate(0, speed, 0);
    }
}
