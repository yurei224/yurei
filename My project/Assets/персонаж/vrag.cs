using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrag : MonoBehaviour
{
    public float Speed;

    public int health;

    Transform pleer;

    void Start()
    {
        pleer = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, pleer.position, Speed * Time.deltaTime);

        if(health < 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
