using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 4.0f;
    private Rigidbody2D m_rigid;
    private Vector2 movement = new Vector2();
    // Start is called before the first frame update
    public void Init(Rigidbody2D rigid)
    {
        m_rigid = rigid;
    }

    
    public void Move()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement.Normalize();
        m_rigid.velocity = movement * moveSpeed;
    }
    
}
