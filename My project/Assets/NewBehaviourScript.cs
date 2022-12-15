using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public void Play()//начало игры1
    {
        SceneManager.LoadScene(0);
    }
    [SerializeField] private Text coinsText;
   
    public void exit()
    {
        //SceneManager.Qult();
        Application.Quit();
        
        
    }
    public void exit2()
    {
        Application.Quit(0);
    }
    public void Play2()//начало игры2
    {
        SceneManager.LoadScene(1);
    }

}
