using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class joystick : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public void OnBeginDrag(PointerEventData eventData) 
    { 
        Debug.Log("Begin");
    }

    public void OnDrag(PointerEventData eventData) 
    { 
        Debug.Log("Drag"); 
    } 
    
    public void OnEndDrag(PointerEventData eventData) 
    { 
        Debug.Log("End"); 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
