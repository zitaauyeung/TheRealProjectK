using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAroundMap : MonoBehaviour
{
    public Transform node;

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.name == "player")
        {
            Debug.Log(node.transform.tag);
            c.transform.position = node.position;
            if (node.transform.tag == "Inside" || node.transform.tag == "WCdoors")
            {
                c.GetComponent<BoxCollider2D>().offset = new Vector2(0.0140571f, -0.4498277f);
                c.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Player 1");
            }
            else
            {
                c.GetComponent<BoxCollider2D>().offset = new Vector2(0f, -0.12f);
                c.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("BetterMinimapPlayer");
            } 
        }
    }
}
