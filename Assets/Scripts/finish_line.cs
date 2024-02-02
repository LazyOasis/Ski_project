using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class finish_line : MonoBehaviour
{
    [SerializeField] float finish_delay = 1f;
    
    void OnTriggerEnter2D( Collider2D other) 
    {
        if(other.tag == "Player")
        {
            Invoke("ReloadScene", finish_delay); //Invoke(function to call, seconds in f)
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
