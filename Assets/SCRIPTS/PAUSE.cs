using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PAUSE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ongamePause()
    {
        Time.timeScale = 0;
    }
    public void ongameResume()
    {
        Time.timeScale = 1;
    }

    public void OnRestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
