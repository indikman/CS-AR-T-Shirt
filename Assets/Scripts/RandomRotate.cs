using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour
{

    public float minSpeed;
    public float maxSpeed;

    private Vector3 rotateSpeed;

    void Start()
    {
        rotateSpeed = new Vector3(Random.Range(minSpeed, maxSpeed), Random.Range(minSpeed, maxSpeed), Random.Range(minSpeed, maxSpeed));
    }


    void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime);
    }
}
