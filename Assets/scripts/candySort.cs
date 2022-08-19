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

    private Vector3 temp;

    private List<GameObject> totalPieces = new List<GameObject>{};

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sortEnter() {
        temp = player.transform.GetChild(0).transform.position;
        player.transform.GetChild(0).transform.position = new Vector3(40f, 70f, -10f);
        this.gameObject.SetActive(true);
        for (int i = 0; i < 9; i++)
        {
            totalPieces.Add(Instantiate(iPiece,new Vector2(Random.Range(35,46),70f), this.transform.rotation));
            totalPieces.Add(Instantiate(squarePiece, new Vector2(Random.Range(35, 46), 71f), this.transform.rotation));
            totalPieces.Add(Instantiate(tPiece, new Vector2(Random.Range(35, 46), 69.5f), this.transform.rotation));
            totalPieces.Add(Instantiate(sPiece, new Vector2(Random.Range(35, 46), 68.5f), this.transform.rotation));
            totalPieces.Add(Instantiate(zPiece, new Vector2(Random.Range(35, 46), 69f), this.transform.rotation));
            totalPieces.Add(Instantiate(lPiece, new Vector2(Random.Range(35, 46), 71.5f), this.transform.rotation));
            totalPieces.Add(Instantiate(jPiece, new Vector2(Random.Range(35, 46), 70.5f), this.transform.rotation));
        }
    }

    public void sortExit() { 
        player.transform.GetChild(0).transform.position = temp;
        this.gameObject.SetActive(false);
        for (int i = 0; i < totalPieces.Count; i++) {
            Destroy(totalPieces[i]);
        }
        totalPieces.Clear();

    }
}
