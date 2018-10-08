using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danbelController : MonoBehaviour {

    private Rigidbody2D rigidDanbel;

    float timer = 3.0f;
    public float lostRate = 2.0f;

    GameObject player;
    GameObject uiDir;
    director scoreScript;

    // Use this for initialization
    void Start () {
        this.rigidDanbel = GetComponent<Rigidbody2D>();
        float px = Random.Range(-20, 21);

        rigidDanbel.velocity = new Vector2(px / 10, rigidDanbel.velocity.y);
        Destroy(gameObject, timer);

        this.player = GameObject.Find("UNITYCHAN");

        uiDir = GameObject.Find("UIDirector");
        scoreScript = uiDir.GetComponent<director>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        if (transform.position.x < min.x || transform.position.x > max.x)
        {
            Destroy(gameObject);
        }

    }

    //Playerとの接触
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "UnityChan")
        {
            Destroy(other.gameObject);
        }
    }
}
