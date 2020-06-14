using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridElement : MonoBehaviour
{

    public Vector2 gridPos;
    public GameObject holder;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Joined " + gameObject.name);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Left " + gameObject.name);
    }
}
