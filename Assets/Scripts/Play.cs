using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {

    [SerializeField] GameObject discForPlayerA;
    [SerializeField] GameObject discForPlayerB;
    int noOfDiscsAdded = 0;
    [SerializeField] GameObject wayPoint;

    GameStatus gameStatus;
    // Use this for initialization
    void Start () {
        gameStatus = FindObjectOfType<GameStatus>();

    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnMouseDown()
    {
        Debug.Log("mouse clicked");
        //AddDisc[] adddiscs = FindObjectsOfType<AddDisc>();
        //foreach (var adddisc in adddiscs)
        //adddisc.AddNewDisc();
        if (gameStatus.isPlayable())
        {
            gameStatus.setPlayable(false);
            AddNewDisc();
        }
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
                if (gameStatus.getCurrentPlayer() == "PlayerA")
                {
                    GameObject newDisc = Instantiate(discForPlayerA, wayPoint.transform.position, transform.rotation) as GameObject;
                }
                else if (gameStatus.getCurrentPlayer() == "PlayerB")
                {
                    GameObject newDisc = Instantiate(discForPlayerB, wayPoint.transform.position, transform.rotation) as GameObject;
                }
                noOfDiscsAdded++;
                gameStatus.setPlayable(true);
                gameStatus.setNextPlayer();
            }
        }
    }
}
