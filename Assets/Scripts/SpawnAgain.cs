using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnAgain : MonoBehaviour
{
    public GameObject player,endGamePanel;
    public Vector3 spawnPosition;
    
    void Start()
    {
        
        endGamePanel.SetActive(false);
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        
        if (collision.gameObject.tag == "plane")
        {
            Debug.Log("Çarptý.");
            player.SetActive(false);
            endGamePanel.SetActive(true);
            
            
            

        }
    }
    public void PlayAgainButton()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitScene()
    {
        SceneManager.LoadScene(1);
    }
    
    
}
