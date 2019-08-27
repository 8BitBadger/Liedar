using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    public float speed;

    public float life;

    Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        StartCoroutine(Die());
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = transform.up * speed * Time.deltaTime;
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(life);
        Destroy(gameObject);
    }
}
