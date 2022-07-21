using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class boxDrag : MonoBehaviour, IDragHandler, IEndDragHandler
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
        mousePos.z = 100;
        Vector3 localMousePos = Camera.main.ScreenToWorldPoint(mousePos);
        if (((localMousePos.x < 3.8 || localMousePos.y < 37.4) || (localMousePos.x > 11 || localMousePos.y > 39.4))){}
        else { transform.position = localMousePos; }
    }

    public void OnEndDrag(PointerEventData pointerEventData)
    {
        transform.parent.parent.parent.parent.GetComponent<DatabaseScrambler>().OverlapCheck();
    }
}

//3.8,37.2,90
//11,37.2,90
//3.8,39.4,90
//11,39.4,90

//make boxes drag(check if origin is in permeter of box, check if there is a box on it, set postitions equal(onMouseUp))