using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform pleer;
    private Vector3 oct = new Vector3(0,0,-3);

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = pleer.position + oct;
    }
}
