using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuNameTextScript : MonoBehaviour
{
    public OnHoverUi ui;
    public SelectorProperties sp;
    public Text OptionName;
    public GameObject textBox;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (ui.selectedID)
        {
            case 0:
                OptionName.text = "Close";
                break;
            case 1:
                OptionName.text = "Plant Carrot";
                break;
            case 2:
                OptionName.text = "Plant Pepper";
                break;
            case 3:
                OptionName.text = "Plant Tomato";
                break;
            case 4:
                OptionName.text = "Plant Watermelon";
                break;
            case 5:
                OptionName.text = "Plant Wheat";
                break;
            case 6:
                OptionName.text = "WIP";
                break;
            case 7:
                OptionName.text = "WIP";
                break;
            case 8:
                OptionName.text = "WIP";
                break;
            case 9:
                OptionName.text = "WIP";
                break;
            case 10:
                OptionName.text = "WIP";
                break;
            case 11:
                OptionName.text = "WIP";
                break;
        }
    }
}
