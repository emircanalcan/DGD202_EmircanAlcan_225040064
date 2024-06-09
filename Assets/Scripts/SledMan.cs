using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SledMan : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 direction;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        direction = new Vector2(0, directionY).normalized;
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, direction.y * speed);
    }
}