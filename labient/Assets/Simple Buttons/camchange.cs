using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class camchange : MonoBehaviour
{
   // public GameObject[] hearts;
   // private int life;
    float firstTime = 0f;
    public float timeStart;
    bool timerActive = false;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public float haksayisi = 5f;
    float times = 3f;
    float y = 500;
    float f = 0f;
    bool controller = true;
    float lastTime = 0f;
  
    void Update()
    {
       
        if (controller)
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            times -= 1 * Time.deltaTime;
            if (times < 0.00f)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                controller = false;
            }
        }
        if (timerActive && haksayisi>0)
        {
            timeStart += Time.deltaTime;
            y -= timeStart;
            if (y > 0.00f)
            {
                cam1.SetActive(true);
                cam2.SetActive(false);
               
                print(haksayisi);
            }

            if (y < 0.00f)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                controller = true;
                y= 600;
                timeStart = 0;
                timerActive = !timerActive;
            }
        }
    }
    public void timerButton()
    {
        print(haksayisi);
        haksayisi -= 1;
        if (haksayisi == 3)
            Destroy(heart1.gameObject);
        if (haksayisi == 2)
            Destroy(heart2.gameObject);
        if (haksayisi == 1)
            Destroy(heart3.gameObject);
        timerActive = !timerActive;
    }
 

}