using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridElement : MonoBehaviour
{ 
    public Vector2 gridPos;
    public GameObject holder;
    public PlayerStats stats;
    public bool isSpawned;
    private void Start()
    {
        stats = GameObject.Find("Player").GetComponent<PlayerStats>();
    }
    private void Update()
    {
        if (holder != null && !isSpawned)
        {
            
            switch(holder.GetComponent<CropHolder>().type)
            {
                case "carrot":
                    if(stats.carrot<=0)
                    {
                        return;
                    }
                    stats.carrot--;
                    isSpawned = true;
                    Instantiate(holder, transform);
                    break;
                case "wheat":
                    if (stats.wheat <= 0)
                    {
                        return;
                    }
                    stats.wheat--;
                    isSpawned = true;
                    Instantiate(holder, transform);
                    break;
                case "watermelon":
                    if (stats.watermelon <= 0)
                    {
                        return;
                    }
                    stats.watermelon--;
                    isSpawned = true;
                    Instantiate(holder, transform);
                    break;
                case "pepper":
                    if (stats.pepper <= 0)
                    {
                        return;
                    }
                    stats.pepper--;
                    isSpawned = true;
                    Instantiate(holder, transform);
                    break;
                case "tomato":
                    if (stats.tomato <= 0)
                    {
                        return;
                    }
                    stats.tomato--;
                    isSpawned = true;
                    Instantiate(holder, transform);
                    break;

            }
        }
    }

    
}
