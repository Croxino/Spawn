using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag : MonoBehaviour, IDragHandler, IEndDragHandler
{

    public GameObject bunny;
    private GameObject rabbitInstance;
    public Vector3 mousePos;


    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = new Vector3(378.2f, -117.7f, 0);
    }

    // Use this for initialization
    void Start()
    {
        
    }

    public void Spawn()
    {


        if (Input.GetMouseButtonUp(0))
        {
            mousePos = Input.mousePosition;
            mousePos.z = 290;
            mousePos.x += 200;

            Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            rabbitInstance = Instantiate(bunny, objectPos, Quaternion.identity) as GameObject;
        }

    }

    // Update is called once per frame
    void Update()
    {


        Spawn();
    }
}
