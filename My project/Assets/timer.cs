using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text text;
    public GameObject per;

    public float mil;
    public float sec;
    public float min;

    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        mil += 0.02f;
        if(mil >= 1)
        {
            sec++;
            mil = 0;
        }
        if(sec == 60)
        {
            min++;
            sec = 0;
        }
        //if (sec == 6)        Destroy(per);
        text.text = $"{min} : {sec}" ; 
    }
   
}
