using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameoverscript : MonoBehaviour
{
    public Text pointsText;

    pouz pouz;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + "POINTS";
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void exit()
    {
        SceneManager.LoadScene(0);
    }
    
}
