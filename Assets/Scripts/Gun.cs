using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletObject;
    public void Shoot()
    {
        Instantiate(bulletObject, transform.position, transform.rotation);
    }
}
