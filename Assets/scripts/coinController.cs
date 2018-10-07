using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinController : MonoBehaviour {

    private Rigidbody2D rigid2D;

    float timer = 5.0f;
    public float CoinScore = 10f;

    GameObject player;
    GameObject uiDir;
    director scoreScript;


    // Use this for initialization
    void Start () {
        this.rigid2D = GetComponent<Rigidbody2D>();
        float px = Random.Range(-20, 21);

        rigid2D.velocity = new Vector2(px/10, rigid2D.velocity.y);
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

        //Playerとの接触
        Vector2 coinPos = transform.position;
        Vector2 playerPos = this.player.transform.position;
        Vector2 dir = coinPos - playerPos;
        float d = dir.magnitude;

        var coinColSize = GetComponent<CircleCollider2D>();
        var playerColSize = player.GetComponent<BoxCollider2D>();
        float coinSize = coinColSize.radius;
        float playerSize = playerColSize.size.x;

        if( d < coinSize + playerSize)
        {
            Destroy(gameObject);
            scoreScript.ChangeScore(CoinScore);
        }



    }
}
