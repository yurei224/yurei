using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class pers : MonoBehaviour
{

    public float speed;

    public Rigidbody2D rb;
    private Vector2 MovVelos;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Vector2 MovInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        MovVelos = MovInput * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + MovVelos * Time.fixedDeltaTime);
    }
}