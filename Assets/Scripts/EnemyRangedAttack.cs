using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRangedAttack : MonoBehaviour
{
    public List<Gun> Guns;
    public float reloadTimer;
    Transform target;
    public LayerMask playerMask;
    float timer;

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircle(transform.position, 5, playerMask))
        {
            if (Time.time - timer > reloadTimer)
            {
                timer = Time.time;
                for (int i = 0; i < Guns.Count; i++)
                {
                    Guns[i].Shoot();
                }
            }
        }
    }
}

