using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgController : MonoBehaviour
{

    public float bgSpeed;
    private Rigidbody2D rigid2D;
    GameObject playerOBJ;
    player playerScript;


    // Use this for initialization
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        playerOBJ = GameObject.Find("UNITYCHAN");
        playerScript = playerOBJ.GetComponent<player>();

    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");

        int scrollFlg = playerScript.isScroll;
        if (x != 0 && scrollFlg == 0 )
        {
            
            rigid2D.velocity = new Vector2(x * bgSpeed, rigid2D.velocity.y);

        }

        else
        {
            rigid2D.velocity = new Vector2(0, rigid2D.velocity.y);
        }

    }
}
