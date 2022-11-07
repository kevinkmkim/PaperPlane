using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{

    private float movementSpeed = 5f;
    private bool collided = false;
    public static bool gameOn = false;
    // Update is called once per frame

    // void Start()
    // {

    // }
    void Update()
    {
        if (collided)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        collided = true;
    }
}
