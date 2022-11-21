using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public static int playerHelth;
    public static bool gameOver;
    public Text playerHelthText;



    void Start()
    {
        playerHelth = 200;
        gameOver = false;
    }

    void Update()
    {
        playerHelthText.text = " " + playerHelth;
        if(gameOver)
        {
            SceneManager.LoadScene("menu");
        }
    }

    public static void Damage (int damageCount)
    {
        playerHelth -= damageCount;
        if (playerHelth <= 0)
            gameOver = true;
    }


    
}
