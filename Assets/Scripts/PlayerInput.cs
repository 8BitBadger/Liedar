using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement))]
public class PlayerInput : MonoBehaviour
{

Movement move;
    // Start is called before the first frame update
private void Start()
{
    move = GetComponent<Movement>();
} 

    // Update is called once per frame
    void Update()
    {
        move.SetInput(transform.up.x, transform.up.y, Input.GetAxis("Horizontal"));
    }
}
