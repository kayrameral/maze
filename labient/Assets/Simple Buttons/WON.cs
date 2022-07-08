using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class WON : MonoBehaviour
{
    public float currentTime = 0.000000f;
    
    [SerializeField] Text A;
    public GameObject k;
    public GameObject l;
    public GameObject m;
    public GameObject n;
    
    public GameObject o;

    

    void Update()
    {
        currentTime += 1 * Time.deltaTime;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            gameObject.SetActive(true);
            k.SetActive(true);
            l.SetActive(false);
            m.SetActive(false);
            n.SetActive(false);
            o.SetActive(false);
           
            A.text = "TIME: "+ currentTime.ToString("0.00") +" sn";
            Time.timeScale = 0;
            Time.timeScale = 0;
        }
    }
    
        
}