using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Clock();
        
    }

    void Clock()
    {
        timer = Time.time; //Gathers the time elasped and puts it into a timer.
        timer = Mathf.Round(timer * 100.0f) * 0.01f;//Will round to nearest Hundreth
        text.text = "Time: " + timer.ToString();

        if(timer >= 50)
        {
            Debug.Log("Fail");
        }
    }


}
