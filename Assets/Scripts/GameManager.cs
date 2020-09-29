using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//*
// GameManager.cs
//*
// Class behaviour
//*
// @category   Space Shooter Pro
// @tutorial   GameDevHQ
// @author     Dave González
// @copyright  2020 Dave González
// @version    CVS: 1.0
// @link       website
//*

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private bool _isGameOver;

    private void Update()
    {
        //if the r key was pressed
        //restart the current scene
        if (Input.GetKeyDown(KeyCode.R) && _isGameOver == true)
        {
            SceneManager.LoadScene(1); //Current game scene
        }

        //if the escape key is pressed
        //quit application
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void GameOver()
    {
        _isGameOver = true;
    }
}
