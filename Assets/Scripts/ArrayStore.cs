using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;


public class ArrayStore : MonoBehaviour {

    int[,] table = new int[6, 7];

    private void Awake()
    {
        if (FindObjectsOfType<ArrayStore>().Length > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }


    }
    // Use this for initialization
    void Start ()
    {
        PrintGameArrayStore();
    }

    private void PrintGameArrayStore()
    {
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < 6; i++)
        {

            for (int j = 0; j < 7; j++)
            {

                str.Append("[ " + i + "," + j + "]=" + table[i, j] + "\t");
            }
            str.Append("\n");
        }
        Debug.Log(str);
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void setGameArrayStore(int i, int j, int value)
    {
        table[i, j] = value;
        PrintGameArrayStore();
    }
}
