using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgController : MonoBehaviour
{

    public float bgSpeed;
    private Rigidbody2D rigid2D;

    // Use this for initialization
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        Debug.Log("bgspeed:" + bgSpeed);
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");

        if (x != 0)
        {
            
            rigid2D.velocity = new Vector2(x * bgSpeed, rigid2D.velocity.y);

        }

        else
        {
            rigid2D.velocity = new Vector2(0, rigid2D.velocity.y);
        }

    }
}
