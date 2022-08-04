using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candySort : MonoBehaviour
{
    public GameObject iPiece;
    public GameObject squarePiece;
    public GameObject tPiece;
    public GameObject sPiece;
    public GameObject zPiece;
    public GameObject lPiece;
    public GameObject jPiece;
    public GameObject player;

    private Vector2 temp;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 7; i++) {
            Instantiate(iPiece);
            Instantiate(squarePiece);
            Instantiate(tPiece);
            Instantiate(sPiece);
            Instantiate(zPiece);
            Instantiate(lPiece);
            Instantiate(jPiece);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sortEnter() {
        temp = player.transform.position;
        player.transform.position = new Vector2(40f, 70f);
        this.gameObject.SetActive(true);
    }

    public void sortExit() { 
        player.transform.position = temp;
        this.gameObject.SetActive(false);
        
    }
}
