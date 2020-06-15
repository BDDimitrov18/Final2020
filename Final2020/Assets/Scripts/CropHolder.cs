using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CropHolder : MonoBehaviour
{
    public Crop crop;
    SpriteRenderer rend;
    private void Start()
    {
        rend = gameObject.GetComponent<SpriteRenderer>();
        crop.growthState = 0;
        rend.sprite = crop.tex[crop.growthState];
        crop.growthTime = Mathf.Round(Random.Range(10f, 45f));
    }

    private void Update()
    {
        crop.growthTime -= Time.deltaTime;
        if (crop.growthTime <= 0 && crop.growthState != crop.tex.Length-1)
        {
            crop.growthState++;
            rend.sprite = crop.tex[crop.growthState];
            crop.growthTime = Mathf.Round(Random.Range(10f, 20f));
        }

        if(crop.growthState == crop.tex.Length-1)
        {
            crop.done = false;
        }
    }
}
