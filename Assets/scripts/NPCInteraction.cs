using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCInteraction : MonoBehaviour
{
    //The following is for the icon indicating you can interact with an npc
    public GameObject indict;
    public IEnumerator fadeIn;
    public IEnumerator fadeOut;
    private GameObject obj;

    //Dialogue mechanics
    public GameObject textbox; //The gameobject where the dialBox script can be taken
    public dialogueBox dialBox; //the script refrence that manages dialogue
    public dialogueManager dialManager; //The collection of the ENTIRE script

    //Variables to manage the technical aspects of dialogue
    public bool canMove; //Prevents player movement when in dialogue sequence
    private bool canInteract; //Keeps track if player is near an npc
    private int line; //Keeps track of the line the dialogue sequence is on
    private string npcName; //Distinguishes npcs by name

    private void Start()
    {
        canInteract = false;
        dialBox = textbox.GetComponent<dialogueBox>();
        dialManager = textbox.GetComponent<dialogueManager>();
        line = 0;

        dialBox.dialoguePoof(false);
        npcName = "null";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canInteract = true;
        npcName = collision.transform.name;
        obj = Instantiate(indict, collision.transform.position + (Vector3.up * 0.2f) + Vector3.forward*10, transform.rotation);

        //fadeIn = fade(true);
        //StartCoroutine(fadeIn);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(obj);
        npcName = "null";
        canInteract = false;
        //fadeOut = fade(false);
        //StartCoroutine(fadeOut);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(npcName == "Kid")
                goThruScript(dialManager.meetMatt);
            if (npcName == "Karen")
                goThruScript(dialManager.approachKaren);
            if (npcName == "KevinKeith")
                goThruScript(dialManager.meetKeith);
            if (npcName == "Emu")
                goThruScript(dialManager.meetEmu);
            if (npcName == "Francis")
                goThruScript(dialManager.meetFrancis);
            if (npcName == "Ants")
                goThruScript(dialManager.meetAnts);
            if (npcName == "Owl")
                goThruScript(dialManager.meetOwl);
            if (npcName == "Shady Guy")
                goThruScript(dialManager.meetShadyGuy);
        }
    }

    private void goThruScript(string[] lines)
    {
        if(canInteract)
        {
            Destroy(obj);
            GetComponent<playerMove>().canMove = false;
            if(line < lines.Length)
            {
                dialBox.dialoguePoof(true);
                dialBox.showDialogue(lines[line]);
                line++;
            }
            else
            {
                dialBox.dialoguePoof(false);
                GetComponent<playerMove>().canMove = true;
                line = 0;
            }
        }
    }

    IEnumerator fade(bool enterFade)
    {
        SpriteRenderer[] iChilds = obj.GetComponentsInChildren<SpriteRenderer>();

        if (enterFade)
        {
            float t = 0f;
            while(t < 1)
            {
                t += Time.deltaTime * 5;
                iChilds[0].GetComponent<SpriteRenderer>().color = Color.Lerp(Color.clear, Color.red, t);
                iChilds[1].GetComponent<SpriteRenderer>().color = Color.Lerp(Color.clear, Color.red, t);
                yield return null;
            }
        }
        else
        {
            float t = 0f;
            while (t < 1)
            {
                t += Time.deltaTime * 5;
                iChilds[0].GetComponent<SpriteRenderer>().color = Color.Lerp(Color.red, Color.clear, t);
                iChilds[1].GetComponent<SpriteRenderer>().color = Color.Lerp(Color.red, Color.clear, t);
                yield return null;
            }
            Destroy(obj);
        }
    }




}
