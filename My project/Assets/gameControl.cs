using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControl : MonoBehaviour
{
    public Gameoverscript gem;
   int tim = 0;
        public void GameOver()
    {
        gem.Setup(tim);
    }

    
    
        
    
}
