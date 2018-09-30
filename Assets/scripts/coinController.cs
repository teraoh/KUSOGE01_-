using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinController : MonoBehaviour {

    float gravity = 0.002f;
    float dropSpeed = 0;

    GameObject player;

	// Use this for initialization
	void Start () {
        this.player = GameObject.Find("UNITYCHAN");
	}
	
	// Update is called once per frame
	void Update () {

        dropSpeed -= gravity;

        transform.Translate(0, dropSpeed, 0);

        if (transform.position.y < -0.7f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if(d < r1 + r2)
        {
            Destroy(gameObject);
        }
    }
}
