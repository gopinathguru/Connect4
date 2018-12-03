using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {

    [SerializeField] GameObject discForPlayerA;
    [SerializeField] GameObject discForPlayerB;
    int noOfDiscsAdded = 0;
    [SerializeField] GameObject wayPoint;
    [SerializeField] int columnNumber;

    GameStatus gameStatus;
    ArrayStore gameArrayStore;
    // Use this for initialization
    void Start () {
        gameStatus = FindObjectOfType<GameStatus>();
        gameArrayStore = FindObjectOfType<ArrayStore>();

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

                if (gameStatus.getCurrentPlayer() == "PlayerA")
                {
                    GameObject newDisc = Instantiate(discForPlayerA, wayPoint.transform.position, transform.rotation) as GameObject;
                    gameArrayStore.setGameArrayStore(noOfDiscsAdded, columnNumber, 1);
                }
                else if (gameStatus.getCurrentPlayer() == "PlayerB")
                {
                    GameObject newDisc = Instantiate(discForPlayerB, wayPoint.transform.position, transform.rotation) as GameObject;
                    gameArrayStore.setGameArrayStore(noOfDiscsAdded, columnNumber, 2);
                }

                noOfDiscsAdded++;
                gameStatus.setPlayable(true);
                gameStatus.setNextPlayer();
            }
        }
    }
}
