using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlotScript : MonoBehaviour
{
    public bool isHovered;
    public OnHoverUi ui;
    public SelectorProperties sp;
    Animator anim;
    public GameObject crop;
    public GameObject selectedElement;
    public SelectorProperties props;


    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        selectedElement = props.selected;
        anim.SetBool("Hovered", isHovered);
        if (isHovered)
        {
            if (Input.GetKeyDown("e"))
            {
                if(ui.selectedID!=0)
                {
                    selectedElement.GetComponent<GridElement>().holder = crop;
                }
            }
        }
    }
}
