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
    public bool isTab;
    //public Pickable pickable;
    public bool isX;
    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        selectedElement = sp.selected;
        anim.SetBool("Hovered", isHovered);
        if (isHovered)
        {
            if (Input.GetKeyDown("e"))
            {
                if(isX && isHovered)
                {
                    sp.SelectCropUi.SetActive(false);
                    sp.openedUi = false;
                    Debug.Log(sp.SelectCropUi.active);
                }
                if(!isX)
                {
                    selectedElement.GetComponent<GridElement>().holder = crop;
                }
               
            }
        }
    }
}
