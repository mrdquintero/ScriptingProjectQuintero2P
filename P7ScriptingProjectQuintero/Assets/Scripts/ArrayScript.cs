using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    public GameObject[] players;
    int a = 1;
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < players.Length; i++)
        {

            
            Debug.Log("Player Number " + a + " is named " + players[i].name);
            a++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
