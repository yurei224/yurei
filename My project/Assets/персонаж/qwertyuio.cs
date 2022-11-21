using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class qwertyuio : MonoBehaviour
{
    public GameObject pr;
    public Collider2D p;
    public Collider2D v;

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(p==v)
        Destroy(pr);
    }
}
