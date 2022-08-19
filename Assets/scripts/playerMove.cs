using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public int speed;
    public bool canMove;

    private Rigidbody2D rb;
    private static Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        canMove = true;
        anim = GetComponent<Animator>();
        anim.SetBool("stop", true);
        anim.SetBool("mini", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                rb.velocity = Vector2.left * speed;
                anim.SetBool("stop", false);
                anim.SetTrigger("left");
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                rb.velocity = Vector2.up * speed;
                anim.SetBool("stop", false);
                anim.SetTrigger("up");
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                rb.velocity = Vector2.right * speed;
                anim.SetBool("stop", false);
                anim.SetTrigger("right");
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            {
                rb.velocity = Vector2.down * speed;
                anim.SetBool("stop", false);
                anim.SetTrigger("down");
            }

            if (leftConditions() || upConditions() || rightConditions() || downConditions())
            {
                rb.velocity = Vector2.zero;
                anim.SetBool("stop", true);
            }
        }
    }

    bool leftConditions()
    {
        return Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A);
    }
    bool upConditions()
    {
        return Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W);
    }
    bool rightConditions()
    {
        return Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D);
    }
    bool downConditions()
    {
        return Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S);
    }

    public static void changeMiniStatus(bool value)
    {
        anim.SetBool("mini", value);
    }

    public static void setIdle(string direct)
    {
        anim.SetTrigger(direct);
    }

}
