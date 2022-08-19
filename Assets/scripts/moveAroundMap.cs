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
            if (node.transform.tag == "Inside")
            {
                playerMove.changeMiniStatus(false);
                playerMove.setIdle("down");
                //c.gameObject.GetComponent<Collider2D>().
            }
            else
            {
                playerMove.changeMiniStatus(true);
                if (node.gameObject.name == "parkOutside")
                    playerMove.setIdle("up");
                else
                    playerMove.setIdle("down");
            }
        }
    }
}
