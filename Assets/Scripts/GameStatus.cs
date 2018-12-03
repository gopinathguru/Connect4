using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour {

    [SerializeField] string currentPlayer;
    [SerializeField] bool currentPlayable = true;

	// Use this for initialization
	void Start () {
        currentPlayer = "PlayerA";
        setPlayable(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    public void setPlayable(bool playable) {
        currentPlayable = playable;
    }

    public bool isPlayable()
    {
        return currentPlayable;
    }

    public void setNextPlayer()
    {
        if (currentPlayer == "PlayerA")
            currentPlayer = "PlayerB";
        else if (currentPlayer == "PlayerB")
            currentPlayer = "PlayerA";
    }

    public string getCurrentPlayer()
    {
        return currentPlayer;
    }

}
