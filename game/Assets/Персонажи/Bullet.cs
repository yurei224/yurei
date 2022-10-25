using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Pers pr = new Pers();

    public Rigidbody2D rb;

    public int health;
    public float speed;

    Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Playr").transform;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime); 
    }

    
}
