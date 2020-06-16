using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorProperties : MonoBehaviour
{
    public GameObject crop;
    public GameObject selected;
    public GameObject SelectCropUi;
    private bool openedUi;

    public PlayerInput movement;
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

    private void LateUpdate()
    {
        if (Input.GetKeyDown("e"))
        {
            if (openedUi)
            {
                openedUi = false;
                SelectCropUi.SetActive(false);
                return;
            }
            SelectCropUi.SetActive(true);
            openedUi = true;

        }
        if (openedUi)
        {
            movement.allowMovement = false;
        }
        else
        {
            movement.allowMovement = true;
        }
    }
}
