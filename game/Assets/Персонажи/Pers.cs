using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pers : MonoBehaviour
{
    public float sprrd = 5;
    public int health;

    public Rigidbody2D rb;
    private Vector2 movIm;
    private Vector2 movVe;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        movIm = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        movVe = movIm.normalized * sprrd;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movVe * Time.fixedDeltaTime);
    }

    public void ChangeHealth(int healthValue)
    {
        health += healthValue;
    }
}
