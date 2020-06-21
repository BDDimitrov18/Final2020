using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public bool hasHoe = false;
    public GameObject hoe;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("im in brat");
            hasHoe = true;
            hoe.SetActive(false);
            //col.gameObject.GetComponent<PlayerStats>().inHand = gameObject;
        }
    }
}
