using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public long coin;
    public long carrot;
    public long wheat;
    public long watermelon;
    public long pepper;
    public long tomato;

    public GameObject inHand;
    public GameObject handPanel;

    public TextMeshProUGUI coinstxt;
    public TextMeshProUGUI carrotsTxt;
    public TextMeshProUGUI wheatTxt;
    public TextMeshProUGUI watermelonTxt;
    public TextMeshProUGUI pepperTxt;
    public TextMeshProUGUI tomatoTxt;

    private void Update()
    {
        coinstxt.text = coin.ToString();
        carrotsTxt.text = carrot.ToString();
        wheatTxt.text = wheat.ToString();
        watermelonTxt.text = watermelon.ToString();
        pepperTxt.text = pepper.ToString();
        tomatoTxt.text = tomato.ToString();
        handPanel.GetComponent<Image>().sprite = inHand.GetComponent<SpriteRenderer>().sprite;
    }
}
