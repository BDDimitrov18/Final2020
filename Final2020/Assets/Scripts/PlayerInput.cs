using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float x, y; 
    public float Speed = 3f;
    private float floatSpeed = 0;
    public PlayerMovement mov;
    public string facing;
    public GameObject selector;
    public Vector2 gridPos;
    public bool allowMovement = true;
    public float scroll;
    public Animator anim;

    public GameObject ToolHolder;
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
                gridPos.x += 2;
                anim.SetInteger("Side", 1);
                gameObject.transform.eulerAngles = new Vector3(0f, 180f, 0f);
            }
            else if (facing == "left")
            {
                gridPos.x -= 2;
                anim.SetInteger("Side", 1);
                gameObject.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
            else if (facing == "up")
            {
                gridPos.y += 2;
                anim.SetInteger("Side",2);
            }
            else if (facing == "down")
            {
                gridPos.y -= 2;
                anim.SetInteger("Side", 0);
            }


            selector.transform.position = gridPos;
        }
        else
        {
            x = 0;
            y = 0;
        }


        if (x != 0 || y != 0)
        {
            //sth
        }
        else
        {
            anim.SetInteger("Side", 4);
        }


        scroll = Input.GetAxis("Mouse ScrollWheel");
        if (Camera.main.orthographicSize - scroll * 5 < 10 && Camera.main.orthographicSize - scroll * 5 > 1)
        {
            Camera.main.orthographicSize -= scroll * 5;
        }
        /*************************************************************************/
        

    }

    private void FixedUpdate()
    {
        mov.Move(x, y);
      
    }

    
}
