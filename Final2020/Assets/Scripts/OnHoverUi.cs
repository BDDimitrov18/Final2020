using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHoverUi : MonoBehaviour
{
    public SelectorProperties selectorScript;
    public List<GameObject> itemSlots;
    public int selectedID=0;
    int lastSelectedId =0;
    int countSlots = 0;
    private void Start()
    {
        foreach (Transform child in transform)
        {
            if (child.gameObject.tag == "Tab")
            {
                foreach(Transform kid in child.gameObject.transform)
                {
                    if (kid.tag == "ItemSlot" && kid.gameObject.active)
                    { 
                        
                    }
                }
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("right"))
       {
            selectedID++;
        }
        if (Input.GetKeyDown("left"))
        {
            selectedID--;
        }
        if (Input.GetKeyDown("up"))
        {
            selectedID -= 3;
        }
        if (Input.GetKeyDown("down"))
        {
            selectedID += 3;
        }

        if (selectedID < 0)
        {
            selectedID = 0;
        }
        if (selectedID > itemSlots.Count-1)
        {
            selectedID = itemSlots.Count-1;
        }
        if (lastSelectedId != selectedID)
        {
            itemSlots[lastSelectedId].GetComponent<ItemSlotScript>().isHovered = false;
        }
        itemSlots[selectedID].GetComponent<ItemSlotScript>().isHovered = true;
        lastSelectedId = selectedID;
    }
}
