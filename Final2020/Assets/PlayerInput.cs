using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float x, y; 
    public float Speed = 3f;
    public PlayerMovement mov;
    private void Update()
    {
        x = Input.GetAxisRaw("Horizontal") * Speed;
        y = Input.GetAxisRaw("Vertical") * Speed;
    }

    private void FixedUpdate()
    {
        mov.Move(x, y);
    }
}
