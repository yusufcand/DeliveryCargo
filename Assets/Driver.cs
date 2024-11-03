using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 25f;
   
  

    
    void Update()
    {
        float steerAmont = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmont);
        transform.Translate(0, moveAmount, 0);
        
    }

     void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowSpeed;
    }



    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }
}
