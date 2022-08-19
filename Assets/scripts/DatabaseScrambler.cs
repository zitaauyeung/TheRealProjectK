using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DatabaseScrambler : MonoBehaviour
{
    public GameObject panel;
    public GameObject phoneEdge;
    public GameObject profileObj;
    public GameObject box;
    public GameObject letters;

    public Transform boxSlot2;
    public Transform letterSlot2;

    public Transform boxSlot;
    public Transform letterSlot;

    List<GameObject> slotBoxes = new List<GameObject> { };
    List<GameObject> slots = new List<GameObject> { };
    List<GameObject> letterSlots = new List<GameObject> { };

    public Text nameBox;
    private Transform currentButton;

    private bool longName = false;
   
    string[] charList = new string[] {"*construction noises*", "antersons", "boss", "francis", "harry", "irwin", "karen", "keith/kevin kevin/keith", "matt", "robert", "shady", "wolfgang"};
    string[] scrambledCharList = new string[] { "*tinonorccuts onssie*", "sensnarto", "osbs", "carsfin", "rhyra", "riwin", "anrek", "kehit venki/venik hekti", "tamt", "orrbte", "daysughy", "nawlgfog" };

    private int listVal = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkLock(Transform input)
    {
        currentButton = input;
        if (input.name == "*construction noises*")
        {
            longName = true;
        }
        else
        {
            longName = false;
        }
        int num = 0;
        for (int i = 0; i < charList.Length; i++)
        {
            if (charList[i] == input.name)
            {
                listVal = i;
                num = i;
            }
        }
        if (input.CompareTag("locked"))
        {
            panel.SetActive(true);
            phoneEdge.SetActive(true);
            setUp();
        }
        else if (input.CompareTag("unlocked"))
        {
            profileObj.SetActive(true);
            profileObj.GetComponent<profile>().setUp(num);
            currentButton.parent.gameObject.SetActive(false);
        }
    }

    public void exitDatabase()
    {
        phoneEdge.transform.parent.GetChild(1).gameObject.SetActive(true);
        phoneEdge.transform.parent.GetChild(2).gameObject.SetActive(false);
    }

    public void exitScrambler()
    {
        panel.SetActive(false);
        phoneEdge.SetActive(false);
        foreach (GameObject s in slots)
        {
            Destroy(s);
        }
        slots.Clear();
        slotBoxes.Clear();
        letterSlots.Clear();
    }

    public void setUp()
    {
        nameBox.text = scrambledCharList[listVal];
        if (longName == true)
        {
            Debug.Log("s");
            for (int i = 1; i < 13; i++)
            {
                GameObject y = Instantiate(box, boxSlot);
                GameObject x = Instantiate(letters, letterSlot);
                slots.Add(x);
                slots.Add(y);
                letterSlots.Add(x);
                slotBoxes.Add(y);
                x.SetActive(true);
                x.transform.GetChild(0).GetComponent<Text>().text = scrambledCharList[listVal][i].ToString();
                y.transform.GetChild(0).GetComponent<Text>().text = charList[listVal][i].ToString();
            }
            for (int i = 14; i < (charList[listVal].Length-1); i++)
            {
                GameObject y = Instantiate(box, boxSlot2);
                GameObject x = Instantiate(letters, letterSlot2);
                slots.Add(x);
                slots.Add(y);
                letterSlots.Add(x);
                slotBoxes.Add(y);
                x.SetActive(true);
                x.transform.GetChild(0).GetComponent<Text>().text = scrambledCharList[listVal][i].ToString();
                y.transform.GetChild(0).GetComponent<Text>().text = charList[listVal][i].ToString();
            }
        }
        else
        {
            for (int i = 0; i < charList[listVal].Length; i++)
            {
                GameObject y = Instantiate(box, boxSlot);
                GameObject x = Instantiate(letters, letterSlot);
                slots.Add(x);
                slots.Add(y);
                letterSlots.Add(x);
                slotBoxes.Add(y);
                x.SetActive(true);
                x.transform.GetChild(0).GetComponent<Text>().text = scrambledCharList[listVal][i].ToString();
                y.transform.GetChild(0).GetComponent<Text>().text = charList[listVal][i].ToString();
            }
        }
    }

    public void OverlapCheck()
    {
        foreach (GameObject s in slotBoxes)
        {
            Collider2D[] pointsHit = Physics2D.OverlapPointAll(s.transform.position);
            foreach (Collider2D t in pointsHit)
            {
                if (t.transform.tag == "fill")
                {
                    bool check = false;
                    foreach (GameObject u in letterSlots)
                    {
                        if (u.transform.position == s.transform.position)
                        {
                            check = true;
                        }
                    }
                    if (check == false)
                    {
                        print(t.transform.position);
                        t.transform.position = s.transform.position;
                    }
                }
            }
        }
    }

    public void checkLetters()
    {
        bool done = true;
        int counter = 0;
        foreach (GameObject x in slotBoxes)
        {
            bool filled = false;
            
            if (x.transform.GetComponent<Image>().color != Color.green)
            {
                done = false;
            }
            foreach (GameObject y in letterSlots)
            {
                if (x.transform.position == y.transform.position)
                {
                    filled = true;
                    if (x.transform.GetChild(0).GetComponent<Text>().text == y.transform.GetChild(0).GetComponent<Text>().text)
                    {
                        x.transform.GetComponent<Image>().color = Color.green;
                        y.transform.GetComponent<Image>().color = Color.green;
                    }
                    else
                    {
                        x.transform.GetComponent<Image>().color = Color.red;
                        y.transform.GetComponent<Image>().color = Color.red;
                    }
                }
            }
            if (filled == false) {
                x.transform.GetComponent<Image>().color = Color.red;
                letterSlots[counter].transform.GetComponent<Image>().color = Color.red;
            }
            counter++;
        }
        if (done == true)
        {
            currentButton.tag = "unlocked";
            currentButton.GetChild(0).GetComponent<Text>().text = currentButton.name;
        }
    }
}

//make boxes drag, change color on enter, unlock
//or
//open to profile, change picture and description
//go back button
//