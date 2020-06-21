using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Animator animator;
    public Camera cam;
    public float x, y; 
    public float Speed = 3f;
    private float floatSpeed = 0;
    public PlayerMovement mov;
    public string facing;
    public GameObject selector;
    public Vector2 gridPos;
    public bool allowMovement = true;
    public float scroll;
    private void Update()
    {
        if (allowMovement)
        {
            x = Input.GetAxisRaw("Horizontal") * Speed;
            y = Input.GetAxisRaw("Vertical") * Speed;
            gridPos.x = Mathf.Round(transform.position.x);
            gridPos.y = Mathf.Round(transform.position.y);
            if (Input.GetKeyDown("right"))
            {
                facing = "right";
                animator.SetFloat("horizontal", 1);
                animator.SetFloat("vertical", 0);
            }
            if (Input.GetKeyDown("left"))
            {
                facing = "left";
                animator.SetFloat("horizontal",-1);
                animator.SetFloat("vertical", 0);
            }
            if (Input.GetKeyDown("up"))
            {
                facing = "up";
                animator.SetFloat("vertical", 1);
                animator.SetFloat("horizontal", 0);
            }
            if (Input.GetKeyDown("down"))
            {
                facing = "down";
                animator.SetFloat("vertical", -1);
                animator.SetFloat("horizontal", 0);
            }
            

            if (facing == "right")
            {
                gridPos.x += 2;
            }
            else if (facing == "left")
            {
                gridPos.x -= 2;
            }
            else if (facing == "up")
            {
                gridPos.y += 2;
            }
            else if (facing == "down")
            {
                gridPos.y -= 2;
            }
            selector.transform.position = gridPos;
        }
        else
        {
            x = 0;
            y = 0;
        }

        scroll = Input.GetAxis("Mouse ScrollWheel");
        if (Camera.main.orthographicSize - scroll * 5 < 10 && Camera.main.orthographicSize - scroll * 5 > 1)
        {
            Camera.main.orthographicSize -= scroll * 5;
        }
        
    }

    private void FixedUpdate()
    {
        mov.Move(x, y);
        if (Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right") || Input.GetKey("up"))
            animator.SetBool("isMoving", true);
        else
            animator.SetBool("isMoving", false);
    }

    
}
