using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Economy : MonoBehaviour
{

    public PlayerStats stats;
    public Crop crop;
    void Start()
    {
        stats.coin = 1000;
    }

    void Update()
    {
        
    }

    void SellCrop()
    {
        stats.coin += crop.price;
        crop.price = ((long)(crop.price/0.2));
    }

    void BuyCrop()
    {
        stats.coin -= crop.price;
        crop.price = (long)(crop.price * 0.2);
    }
}
