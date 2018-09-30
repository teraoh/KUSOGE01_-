using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinGenerator: MonoBehaviour {

    public GameObject coinPrefab;
    float span = 0.2f;
    float delta = 0 ;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(coinPrefab) as GameObject;
            int px = Random.Range(-3, 4);
            go.transform.position = new Vector3(px, 9, 0);
        }
	}
}
