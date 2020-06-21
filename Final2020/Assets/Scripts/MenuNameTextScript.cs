using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MenuNameTextScript : MonoBehaviour
{
    public OnHoverUi ui;
    public TextMeshProUGUI text;

    void Update()
    {
        text.text = ui.selectables[ui.selectedID].gameObject.name;
    }
}
