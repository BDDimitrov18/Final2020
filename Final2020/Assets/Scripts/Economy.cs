using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Economy : MonoBehaviour
{
    public float playerMoney;
    public Crop crop;
    void Start()
    {
        playerMoney = 1000;
    }

    void Update()
    {
        
    }

    void SellCrop()
    {
        playerMoney += crop.price;
        crop.price = (float)(crop.price/0.2);
    }

    void BuyCrop()
    {
        playerMoney -= crop.price;
        crop.price = (float)(crop.price * 0.2);
    }
}
