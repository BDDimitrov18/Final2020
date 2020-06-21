using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridElement : MonoBehaviour
{ 
    public Vector2 gridPos;
    public GameObject holder;
    public PlayerStats stats;
    public bool allowSpawn;
    public bool Soiled = true;
    public GameObject HolderTo;
    private void Start()
    {
        stats = GameObject.Find("Player").GetComponent<PlayerStats>();
    }
    private void Update()
    {
        if (holder != null && allowSpawn)
        {
            if (holder.tag == "Soil")
            {
                HolderTo = holder;
                allowSpawn = false;
            }
            switch(holder.GetComponent<CropHolder>().type)
            {
                case "carrot":
                    if(stats.carrot<=0)
                    {
                        return;
                    }
                    stats.carrot--;
                    HolderTo = holder;
                    break;
                case "wheat":
                    if (stats.wheat <= 0)
                    {
                        return;
                    }
                    stats.wheat--;
                    HolderTo = holder;
                    break;
                case "watermelon":
                    if (stats.watermelon <= 0)
                    {
                        return;
                    }
                    stats.watermelon--;
                    HolderTo = holder;
                    break;
                case "pepper":
                    if (stats.pepper <= 0)
                    {
                        return;
                    }
                    stats.pepper--;
                    HolderTo = holder;
                    break;
                case "tomato":
                    if (stats.tomato <= 0)
                    {
                        return;
                    }
                    stats.tomato--;
                    HolderTo = holder;
                    break;
                    allowSpawn = false;
            }


        }
    }

    
}
