using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class director : MonoBehaviour {

    public float Score = 0;
    public float NowScore = 0;
    public float ScoreRate = 1.1f;

    GameObject scoreLavel;

    // Use this for initialization
    void Start () {
        this.scoreLavel = GameObject.Find("score");
	}
	
	// Update is called once per frame
	void Update () {
		if( NowScore < Score)
        {
            NowScore += 1.0f;
            if (NowScore > Score)
            {
                NowScore = Score;
            }
        }

        scoreLavel.GetComponent<Text>().text = "SCORE: " + NowScore + "Pt";

	}

    public void ChangeScore(float def)
    {
        Score += def * ScoreRate;
    }
}
