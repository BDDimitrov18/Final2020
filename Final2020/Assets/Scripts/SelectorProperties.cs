using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorProperties : MonoBehaviour
{
    public GameObject crop;
    public GameObject selected;
    public GameObject SelectCropUi;
    public bool openedUi;

    public PlayerInput movement;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Tile")
        {
            selected = collision.gameObject;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            if (!openedUi)
            {
                SelectCropUi.SetActive(true);
                openedUi = true;
            }
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
