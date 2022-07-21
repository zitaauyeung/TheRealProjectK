using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phoneUI : MonoBehaviour
{
    public GameObject bigPhone;
    public GameObject miniPhone;
    public GameObject phoneButton;

    // Start is called before the first frame update
    void Start()
    {
        phoneButton.SetActive(true);
        miniPhone.SetActive(false);
        bigPhone.SetActive(false);
    }

    public void fullScreen()
    {
        miniPhone.SetActive(false);
        bigPhone.SetActive(true);
        bigPhone.transform.GetChild(1).gameObject.SetActive(true);
    }

    public void minimize()
    {
        miniPhone.SetActive(true);
        bigPhone.SetActive(false);
    }

    public void exitPhone()
    {
        phoneButton.SetActive(true);
        miniPhone.SetActive(false);
        bigPhone.SetActive(false);
    }

    public void openPhone()
    {
        miniPhone.SetActive(true);
        phoneButton.SetActive(false);
    }

    public void openDatabase()
    {
        miniPhone.SetActive(false);
        bigPhone.SetActive(true);
        bigPhone.transform.GetChild(1).gameObject.SetActive(false);
        bigPhone.transform.GetChild(2).gameObject.SetActive(true);
        bigPhone.transform.GetChild(2).GetChild(0).gameObject.SetActive(true);
    }
}
