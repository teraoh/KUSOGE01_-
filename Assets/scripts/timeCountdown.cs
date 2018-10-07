using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timeCountdown : MonoBehaviour {

    GameObject timeCounter;

    TextMeshProUGUI timerText;
   
    public float totalTime;
    int seconds;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        timerText = GameObject.Find("countTimer").GetComponent<TextMeshProUGUI>();
        timerText.text = seconds.ToString();
    }
}