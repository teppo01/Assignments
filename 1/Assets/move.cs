using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    float turnspeed = 100.0f;

    float movespeed = 0.02f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * turnspeed * Input.GetAxis("Horizontal") * Time.deltaTime);


        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(0.0f, 0.0f, zDirection);

        transform.position += moveDirection * movespeed;

    }
}
