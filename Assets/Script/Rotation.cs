using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private bool rotateLeft = false; 

    // Update is called once per frame
    void Update()
    {
        if (rotateLeft)
        {
            transform.Rotate(0f, 0f, -speed * Time.deltaTime); 
        }
        else
        {
            transform.Rotate(0f, 0f, speed * Time.deltaTime); 
        }
    }
}
