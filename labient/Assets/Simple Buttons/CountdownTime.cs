using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountdownTime : MonoBehaviour
{
    public float currentTime = 0.000000f;
    public float startTime = 0f;
    public GameObject finishh;
    float firstTime= 3f;
    [SerializeField] Text CountdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        firstTime += 1 * Time.deltaTime;
                
        currentTime += 1*Time.deltaTime;
        CountdownText.text = currentTime.ToString("0.00");
        if (currentTime <0.00f)
        {

            // Destroy();

            currentTime = 0.00f;
            finishh.SetActive(true);
            Time.timeScale = 0;
        }
    }
}