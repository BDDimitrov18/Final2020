using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Crop", menuName = "Make Crop")]
public class Crop : ScriptableObject
{
    public string type;
    public Sprite[] tex;
    public int growthState;
    public float growthTime;
    public bool done = false;
    public long price;
    public int count;

    private void Awake()
    {
        price = Random.Range(100, 300);
    }
}
