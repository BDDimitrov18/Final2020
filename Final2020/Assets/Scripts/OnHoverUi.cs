using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHoverUi : MonoBehaviour
{
    public SelectorProperties selectorScript;
    public List<GameObject> tabs;
    public List<GameObject> selectables;
    public int selectedID = 0;
    int lastSelectedId = 0;
    public int currentTab = 0;
    private void Start()
    {
        foreach (Transform child in transform)
        {
            if (child.gameObject.tag == "Tab")
            {
                tabs.Add(child.gameObject);
            }
        }
        arrangeTheList(tabs,tabs[currentTab]);
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
            selectedID -= 4;
        }
        if (Input.GetKeyDown("down"))
        {
            selectedID += 4;
        }

        if (selectedID < 0)
        {
            selectedID = 0;
        }
        if (selectedID > selectables.Count - 1)
        {
            selectedID = selectables.Count - 1;
        }
        if (lastSelectedId != selectedID)
        {
            if (selectables[lastSelectedId].tag == "Tab")
            {
                selectables[lastSelectedId].GetComponent<TabProperies>().isHovered = false;
            }
            else if(selectables[lastSelectedId].tag == "ItemSlot")
            {
                selectables[lastSelectedId].GetComponent<ItemSlotScript>().isHovered = false;
            }
        }
        if (selectables[selectedID].tag == "Tab")
        {
            selectables[selectedID].GetComponent<TabProperies>().isHovered = true;
        }
        else if(selectables[selectedID].tag == "ItemSlot")
        {
            selectables[selectedID].GetComponent<ItemSlotScript>().isHovered = true;
        }
        lastSelectedId = selectedID;

    }

    public void arrangeTheList(List<GameObject> tabs, GameObject tab)
    {
        selectables.Clear();
        int counter = 0;
        int tabcounter = 0;
        List<GameObject> items = new List<GameObject>();
        items = tab.GetComponent<TabProperies>().items;
        selectables.Add(tabs[tabcounter++]);
        foreach (GameObject item in items)
        {
            if (counter < 3)
            {
                selectables.Add(item);
            }
            else
            {
                selectables.Add(tabs[tabcounter++]);
                selectables.Add(item);
                counter = 0;
            }
            counter++;
        }
        if (tabcounter != tabs.Count)
        {
            for (int i = tabcounter; i < tabs.Count; i++)
            {
                selectables.Add(tabs[i]);
            }
        }
    }


    public void SelectTab(GameObject tab)
    {
        tab.GetComponent<TabProperies>().isHovered = false;
        int counter =0;
        foreach (GameObject obj in tabs)
        {      
            if (obj == tab)
            {
                if (currentTab != counter)
                {
                    currentTab = counter;
                    break;
                }
                else
                {

                    return;
                }
            }
            counter++;
        }
        for (int i = 0; i < tabs.Count; i++)
        {
            if (i != currentTab)
            {
                tabs[i].GetComponent<TabProperies>().isActivated = false;
            }
        }
        arrangeTheList(tabs,tabs[currentTab]);
        lastSelectedId = selectedID;
        selectedID = 0;
    }
}
