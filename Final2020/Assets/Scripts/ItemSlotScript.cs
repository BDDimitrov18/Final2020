using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlotScript : MonoBehaviour
{
    public bool isHovered;
    Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        anim.SetBool("Hovered", isHovered);
        if (isHovered)
        {
            if (Input.GetKeyDown("e"))
            { 
                //sthHappens
            }
        }
    }
}
