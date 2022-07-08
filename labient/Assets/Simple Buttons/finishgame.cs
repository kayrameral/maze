using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class finishgame : MonoBehaviour { 
    // public GameObject finish;

    // Start is called before the first frame update
    void Start()
    {
       
    }

   
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}