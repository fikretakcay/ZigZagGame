using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    public Button playButton;
    public Button helpButton;
    public Button exitButton;
    void Start()
    {
        
    }

    
    void Update()
    {
            
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    //public void HelpScene()
    //{
    //    SceneManager.LoadScene(2);
    //}

    
    

}
