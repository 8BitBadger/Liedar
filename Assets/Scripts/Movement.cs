using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //The turn speed for the plane 
    public float turnSpeed;
    //The movement speed for the plane
    public float moveSpeed;

    float x, y , horizontalAxis;
    //The rigidbody for the plane object
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
     
     public void SetInput(float InputX, float InputY, float axis)
     {
        x = InputX;
        y = InputY;
        horizontalAxis = axis;
     }

    // Update is called once per frame
    void Update()
    {

        //The constant forward movement of the plane 
        rb2d.MovePosition(rb2d.position + new Vector2(x, y) * moveSpeed * Time.deltaTime);
        //The turning of the plane
        rb2d.MoveRotation(rb2d.rotation + -horizontalAxis * turnSpeed * Time.deltaTime);
    }
}
