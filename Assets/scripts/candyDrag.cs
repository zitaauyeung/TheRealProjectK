using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class candyDrag : MonoBehaviour, IDragHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnDrag(PointerEventData pointerEventData)
    {
        Vector3 mousePos = Input.mousePosition;
        Debug.Log(mousePos);
        mousePos.z = 100;
        Vector3 localMousePos = Camera.main.ScreenToWorldPoint(mousePos);
        if (((localMousePos.x < 3.8 || localMousePos.y < 37.4) || (localMousePos.x > 11 || localMousePos.y > 39.4))) { }
        else { transform.position = localMousePos; }
    }


    //100,122
    //1100,700
}


