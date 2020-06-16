using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridElement : MonoBehaviour
{ 
    public Vector2 gridPos;
    public GameObject holder;
    public bool isSpawned;
    private void Update()
    {
        if (holder != null && !isSpawned)
        {
            isSpawned = true;
            Instantiate(holder,transform);
        }
    }

    
}
