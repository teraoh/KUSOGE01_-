using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinController : MonoBehaviour {

    private Rigidbody2D rigid2D;

    public float timer = 5.0f;

    // Use this for initialization
    void Start () {
        this.rigid2D = GetComponent<Rigidbody2D>();
        float px = Random.Range(-20, 21);

        rigid2D.velocity = new Vector2(px/10, rigid2D.velocity.y);
        Destroy(gameObject, timer);

        
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
}
