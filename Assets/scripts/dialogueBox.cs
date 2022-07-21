using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueBox : MonoBehaviour
{
    public Text textBox;
    public Font a;
    public CanvasRenderer textRend;
    private Text nameTag;
    public string name;

    bool isDone;

    private void Start()
    {
        isDone = true;
        nameTag = transform.GetChild(1).GetChild(0).gameObject.GetComponent<Text>();
    }

    public void showDialogue(string dialogue)
    {
        if (isDone)
        {
            StartCoroutine(displayText(dialogue, a));
        }
    }

    IEnumerator displayText(string dialogue, Font font)
    {
        isDone = false;
        textBox.text = "";
        textBox.font = font;
        int nameIndex = 0;
        for (int i = 0; i < dialogue.Length; i++)
        {
            if (dialogue.Substring(i, 1) == ":")
            {
                nameIndex = i;
            }
        }
        nameTag.text = dialogue.Substring(0, nameIndex);
        for (int i = nameIndex + 2; i < dialogue.Length; i++)
        {
            textBox.text = textBox.text + dialogue.Substring(i, 1);
            yield return new WaitForSeconds(0.02f);
        }
        isDone = true;
    }

    public void dialoguePoof(bool appears)
    {
        Color c = appears ? Color.white : Color.clear;

        textRend.SetColor(c);
        transform.GetComponent<CanvasRenderer>().SetColor(c);
        transform.GetChild(1).gameObject.GetComponent<CanvasRenderer>().SetColor(c);
        nameTag.gameObject.GetComponent<CanvasRenderer>().SetColor(c);
    }
}
