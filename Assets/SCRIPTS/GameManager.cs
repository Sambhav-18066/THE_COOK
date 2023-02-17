using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public bool IsGameOver { get; private set; }
    [SerializeField]
    private Canvas gameoverCanvas;
    [SerializeField]
    private Canvas youwinCanvas;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void Gamepause ()
    
    
    {
        Time.timeScale = 0;
    
    }

   public void onresumeGame()
    {
        Time.timeScale = 1;
    }

    public void restartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GameOver(bool isWin)
    {
        IsGameOver = true;

        if (isWin)
        {
            Debug.Log("You win!");
            youwinCanvas.enabled = true;
        }
        else
        {
            gameoverCanvas.enabled = true;
            Time.timeScale = 0;
            
            Debug.Log("You lose!");
        }


        
    }


public void onPressStart()
    {
        SceneManager.LoadScene(1);
    }

    public void onNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void  OnclickHome()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void quitGame()
    {
        Application.Quit(0);
    }

}



