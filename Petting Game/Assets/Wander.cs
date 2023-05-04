using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("ChangeDirection", 2f, 2f);
    }

    void ChangeDirection()
    {
        Vector2 direction = new Vector2(Random.Range(-1f, 1f), 0f);
        rb.AddForce(direction * speed);
        Debug.Log("New direction: " + direction);

    }

    void FixedUpdate()
    {
        Collider2D[] hits = Physics2D.OverlapBoxAll(transform.position, GetComponent<BoxCollider2D>().size, 0f);
        foreach (Collider2D hit in hits)
        {
            if (hit.gameObject.CompareTag("Obstacle"))
            {
                rb.AddForce(-rb.velocity.normalized * speed);
                Debug.Log("Velocity: " + rb.velocity);

            }
        }
    }
}
