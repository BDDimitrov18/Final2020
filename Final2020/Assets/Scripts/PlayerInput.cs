using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float x, y; 
    public float Speed = 3f;
    public PlayerMovement mov;
    public string facing;
    public GameObject selector;
    public Vector2 gridPos;
    private void Update()
    {
        x = Input.GetAxisRaw("Horizontal") * Speed;
        y = Input.GetAxisRaw("Vertical") * Speed;
        gridPos.x = Mathf.Round(transform.position.x);
        gridPos.y = Mathf.Round(transform.position.y);
        if (Input.GetKeyDown("right"))
        {
            facing = "right";
        }
       if (Input.GetKeyDown("left"))
        {
            facing = "left";
        }
        if (Input.GetKeyDown("up"))
        {
            facing = "up";
        }
        if (Input.GetKeyDown("down"))
        {
            facing = "down";
        }

        if (facing == "right")
        {
            gridPos.x += 1;
        }
        else if (facing == "left")
        {
            gridPos.x -= 1;
        }
        else if (facing == "up")
        {
            gridPos.y += 1;
        }
        else if (facing == "down")
        {
            gridPos.y -= 1;
        }
        selector.transform.position = gridPos;
    }

    private void FixedUpdate()
    {
        mov.Move(x, y);
    }
}
