using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinController : MonoBehaviour {

    GameObject player;
    private Rigidbody2D rigid2D;

    // Use this for initialization
    void Start () {
        this.player = GameObject.Find("UNITYCHAN");
        this.rigid2D = GetComponent<Rigidbody2D>();
        float px = Random.Range(-20, 21);

        rigid2D.velocity = new Vector2(px/10, rigid2D.velocity.y);
    }
	
	// Update is called once per frame
	void Update () {
       
    }
}
