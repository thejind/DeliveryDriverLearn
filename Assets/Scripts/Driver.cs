using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 50f;
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float slowSpeed = 30f;
    [SerializeField] float boostSpeed = 60f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;

        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        
        if(other.tag == "Booster")
        {
            moveSpeed = boostSpeed;
        }
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowSpeed;
    }
}
