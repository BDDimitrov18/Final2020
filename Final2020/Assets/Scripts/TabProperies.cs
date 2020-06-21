using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabProperies : MonoBehaviour
{
    public List<GameObject> items;
    public bool isActivated;
    public bool isHovered;
    public OnHoverUi ui;
    public GameObject holder;
    Animator anim;
    Transform item;
    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        foreach (Transform child in transform)
        {

            if (child.gameObject.tag == "ItemsHolder")
            { 
                foreach(Transform kid in child)
                {
                    if (kid.gameObject.tag == "ItemSlot")
                    {
                        items.Add(kid.gameObject);
                    }
                }
                break;
            }
        }
    }

    private void Update()
    {
        anim.SetBool("Hovered", isHovered);
        if (Input.GetKeyDown("e") && isHovered)
        {
            isActivated = true;
        }

        if (isActivated)
        {
            holder.SetActive(true);
            ui.SelectTab(gameObject);
        }
        else
        {
            holder.SetActive(false);
        }
    }

}
