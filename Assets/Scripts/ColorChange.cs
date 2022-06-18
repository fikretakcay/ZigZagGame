using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //Color32[] colors = {new Color(0,0,1,1),new Color(0,0,0,1),new Color(1, 0, 0, 1),new Color(1, 1, 0, 1), new Color(0, 1, 1, 1) , new Color(0.5f, 0.2f, 0.4f, 1f) , new Color(0.8f, 0.65f, 0.38f, 0.88f) , new Color(72f, 0.2f, 0.4f, 1) , new Color(0.35f, 0.67f, 0.78f, 1) , Color.cyan,Color.gray };
        
        //if(Random.Range(0,10) == 0)
        //{
        //    colors = Color32[];
        //}
        if (Score.score >= 100 && Score.score < 200)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0,0.1f,0.2f,0.8f);
        }
        else if (Score.score >= 200 && Score.score < 350)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (Score.score >= 350 && Score.score < 500)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (Score.score >= 500 && Score.score <650)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
