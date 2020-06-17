using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MenuNameTextScript : MonoBehaviour
{
    public OnHoverUi ui;
    public TextMeshProUGUI text;

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
                text.text = "Close";
                break;
            case 1:
                text.text = "Carrot";
                break;
            case 2:
                text.text = "Pepper";
                break;
            case 3:
                text.text = "Tomato";
                break;
            case 4:
                text.text = "Watermelon";
                break;
            case 5:
                text.text = "Wheat";
                break;
            case 6:
                text.text = "WIP";
                break;
            case 7:
                text.text = "WIP";
                break;
            case 8:
                text.text = "WIP";
                break;
            case 9:
                text.text  = "WIP";
                break;
            case 10:
                text.text = "WIP";
                break;
            case 11:
                text.text = "WIP";
                break;
        }
    }
}
