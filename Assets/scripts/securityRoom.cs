using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class securityRoom : MonoBehaviour
{
    //Use prefab for buttons to make them easy to generate
    public GameObject button;
    public GameObject UILocation;

    //UI For code to enter security
    private string code;
    private static bool unlocked;

    // Start is called before the first frame update
    void Start()
    {
        for(int y = -200; y < 201; y += 200)
        {
            for(int x = -200; x < 201; x+=200)
            {
                GameObject temp = Instantiate(button, new Vector2(x, y), Quaternion.identity);
                temp.transform.parent = UILocation.transform;
            }
        }
        unlocked = false;
        code = "";
    }

    private void Update()
    {
        autoNumDetect();
        if (Input.GetKeyDown(KeyCode.Return))
        {
            checkCode();
        }
    }

    private void checkCode()
    {
        if(code == "158")
        {
            Debug.Log("You got it!");
            unlocked = true;
        }
        else
        {
            Debug.Log("Try again...");
            code = "";
        }
    }

    public void numDetect(Text t)
    {
        code += t.text;
    }

    private void autoNumDetect()
    {
        for(int i = 0; i < 10; i++)
        {
            if (Input.GetKeyDown(i + ""))
            {
                code += i;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter code:");
        Debug.Log(code);
    }
}
