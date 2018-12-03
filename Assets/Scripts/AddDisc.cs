using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDisc : MonoBehaviour {
    [SerializeField] GameObject disc;

    int noOfDiscsAdded = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //  AddNewDisc();
    }

    public void OnMouseDown()
    {
        Debug.Log("Sprite Clicked");

    }

    public void AddNewDisc()
    {
        if (noOfDiscsAdded < 6)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector2 discPosition = new Vector2(transform.position.x / Screen.width * 16f, transform.position.y / Screen.width * 16f);
                //Debug.Log("Transform x = " + transform.position.x + " Transform y = " + transform.position.y );

                //Debug.Log("Transform x = "+transform.position.x / Screen.width * 16f + " Transform y = " + transform.position.y / Screen.width * 16f);
                //Debug.Log(transform.position.x / Screen.width * 16f + " " + transform.position.y / Screen.width * 16f);
                //Debug.Log("Mouse X = "+Input.mousePosition.x +" Mouse Y="+ Input.mousePosition.y );
                //Debug.Log("Mouse X = " + Input.mousePosition.x / Screen.width * 16f + " Mouse Y=" + Input.mousePosition.y / Screen.width * 16f);
                GameObject newDisc = Instantiate(disc, transform.position, transform.rotation) as GameObject;

                noOfDiscsAdded++;
            }
        }
    }
}
