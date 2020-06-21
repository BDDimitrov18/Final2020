using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Economy : MonoBehaviour
{

    public PlayerStats stats;
    public Crop carrot;
    public Crop pepper;
    public Crop wheat;
    public Crop tomato;
    public Crop watermelon;
    void Start()
    {
        stats.coin = 100;
    }

    void SellCrop(Crop crop)
    {
        crop.price -= Random.Range(2,6);
    }

    void BuyCrop(Crop crop)
    {
        crop.price += Random.Range(2, 6);
    }
}
