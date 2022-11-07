using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject playButton;
    [SerializeField]
    GameObject plane;

    private bool play = false;
    private float speed = 0f;
    private float maxSpeed = 10f;
    private float acceleration = 2f;

    void Update()
    {
        if (play)
        {
            Debug.Log(speed);
            if (speed < maxSpeed)
            {
                speed += acceleration * Time.deltaTime;
            }
            plane.transform.position += new Vector3(0f,0f,speed * Time.deltaTime);
        }
    }

    public void Play()
    {
        Destroy(playButton);
        play = true;
    }
}
