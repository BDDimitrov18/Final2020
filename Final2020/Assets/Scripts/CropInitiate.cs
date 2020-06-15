using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropInitiate : MonoBehaviour
{
    public Crop crop;
    void Start()
    {
        Initiate();
    }

    public void Initiate()
    {
        if(crop.type=="carrot")
        {
            //crop.tex = 
            crop.growthState = 0;
        }
        if (crop.type == "potato")
        {
            //crop.tex = potato
            crop.growthState = 0;
        }
    }

}
