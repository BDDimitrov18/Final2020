using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D m_Rigidbody2D;
    public Vector3 m_Velocity;
    [Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;
    public void Move(float x,float y)
    {
        if (x != 0)
        {
            Vector3 targetVelocityj = new Vector2(1 * x, m_Rigidbody2D.velocity.y);
            m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetVelocityj, ref m_Velocity, m_MovementSmoothing);
        }  
        if (y != 0)
        {
            Vector3 targetVelocityj = new Vector2(m_Rigidbody2D.velocity.x, 1 * y);
            m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetVelocityj, ref m_Velocity, m_MovementSmoothing);
        }
        if (x == 0 && y == 0)
        {
            m_Rigidbody2D.velocity = Vector3.zero;
        }
    }
}
