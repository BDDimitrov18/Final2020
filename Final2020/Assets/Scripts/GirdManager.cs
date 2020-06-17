using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GirdManager : MonoBehaviour
{
    public int rows =10;
    public int cols = 10;
    public GameObject refTile;

    public float tileSize = 1;

    private void Start()
    {
        
        GenerateGrid();
    }

    public void GenerateGrid()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                GameObject tile = (GameObject)Instantiate(refTile, transform);
                
                float posX = col * tileSize;
                float posY = row * -tileSize;

                tile.transform.position = new Vector2(posX, posY);
            }
        }
        float gridW = cols * tileSize;
        float gridH = rows * tileSize;
        transform.position = new Vector2(-gridW / 2 + tileSize / 2 + 0.5f,gridH / 2 - tileSize / 2 + 0.5f);
    }
}
