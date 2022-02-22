using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    //public GameObject gameOverUI;
    public GameObject pausemenu;

    private void Start()
    {
        //Time.timeScale = 0f;
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = true;
    }

    void Update()
    {
        pausemenu.SetActive(true);
        //Time.timeScale = 0f;
        //Cursor.lockState = CursorLockMode.None;
        //Cursor.visible = true;

    }

    /*
    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
        Time.timeScale = 1f;
        
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit()
    {
        Application.Quit();
    }
    */
}
