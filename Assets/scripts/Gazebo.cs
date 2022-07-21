using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gazebo : MonoBehaviour
{
    public GameObject frame;
    // Start is called before the first frame update
    void Start()
    {
        frame.SetActive(false);
        if (frame.activeSelf)
        {
            Debug.Log("t");
        }
        else
        {
            Debug.Log("f");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("skdfhal");
        if (frame.activeSelf)
        {
            frame.SetActive(false);
        }
        else
        {
            frame.SetActive(true);
        }
    }
}
