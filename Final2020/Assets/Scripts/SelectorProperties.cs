using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorProperties : MonoBehaviour
{
    public GameObject crop;
    public GameObject selected;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Tile")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.black;
            selected = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Tile")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown("e"))
        {
            if (selected.gameObject.GetComponent<GridElement>().holder == null)
            {
                selected.gameObject.GetComponent<GridElement>().holder = crop;
            }
        }
    }
}
