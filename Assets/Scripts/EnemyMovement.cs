using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement))]
public class EnemyMovement : MonoBehaviour
{
    Transform target;
    Movement move;
    public LayerMask playerMask;
    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        target = Physics2D.OverlapCircle(transform.position, 5, playerMask).transform;
        if(target == null) return;
        //if(Vector2.Angle(transform.position, target.position) > 2) 
        Vector2 dir = target.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        
Debug.Log("angle = " + Vector2.SignedAngle(transform.position, target.position));
//move.SetInput(0,0,)
    }
}
