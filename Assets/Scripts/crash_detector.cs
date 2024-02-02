using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crash_detector : MonoBehaviour
{
    [SerializeField] float crash_delay = 1f;

    void OnTriggerEnter2D( Collider2D other) //We use on trigger becsuse it will only call once
    {
        if(other.tag == "Ground")
        {
            Invoke("ReloadScene", crash_delay); //Invoke(function to call, seconds in f)
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
;    }
}
