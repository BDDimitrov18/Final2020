using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{ 
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("im in brat");
            col.gameObject.GetComponent<PlayerStats>().inHand = gameObject;
        }
    }
}
