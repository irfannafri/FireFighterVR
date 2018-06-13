using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timer : MonoBehaviour  {

    public Text TimerText;
    private float StartTime = 120;
    public GameObject gameOver;

    // Use this for initialization
    void Start()    {
        TimerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()   {
        StartTime -= Time.deltaTime;
        TimerText.text = StartTime.ToString("f0");
        if (StartTime <= 0) {
            int menuTerbaru = 0;
            Application.LoadLevel(menuTerbaru);
        }
    }
}