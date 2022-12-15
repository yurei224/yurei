using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Xml.Serialization;
using System.IO;

public class rec : MonoBehaviour
{
    public InputField inp;
    //public Scrollbar tex;
    public Text tex;

    

    void Start()
    {
        
    }

    public void MyText()
    {
        tex.text = inp.text;
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    
}
