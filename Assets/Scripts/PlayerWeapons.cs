using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapons : MonoBehaviour
{
    public List<Gun> Guns;

    public float reloadTimer;

    float timer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
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
