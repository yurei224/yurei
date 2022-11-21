using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrag : MonoBehaviour
{
    public float Speed;

    Transform pleer;

    void Start()
    {
        pleer = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, pleer.position, Speed * Time.deltaTime);
    }
}
