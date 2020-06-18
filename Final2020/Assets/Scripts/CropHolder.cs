using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CropHolder : MonoBehaviour
{
    public string type;
    public Sprite[] tex;
    public int growthState;
    public float growthTime;
    public bool done = false;
    public float price;
    public int count;
    SpriteRenderer rend;
    private void Start()
    {
        rend = gameObject.GetComponent<SpriteRenderer>();
        growthState = 0;
        rend.sprite = tex[growthState];
        growthTime = Mathf.Round(Random.Range(10f, 20f));
    }

    private void Update()
    {
        growthTime -= Time.deltaTime;
        if (growthTime <= 0 && growthState != tex.Length-1)
        {
            growthState++;
            growthTime = Mathf.Round(Random.Range(10f, 20f));
        }
        rend.sprite = tex[growthState];
        if (growthState == tex.Length-1)
        {
            done = true;
        }
    }
}
