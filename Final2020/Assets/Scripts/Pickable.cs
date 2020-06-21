using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public GameObject hoe;
    public GameObject Dirt;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("im in brat");
            hoe.SetActive(false);
            col.gameObject.GetComponent<PlayerStats>().inHand = gameObject;
        }
    }
}
