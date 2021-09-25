using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 4.0f;
    private Rigidbody2D m_rigid;
    private Vector2 movement = new Vector2();

    private float curTime;
    private float coolTime = 0.2f;
    
    public float playerStamina = 100.0f;

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

    public void Dash(float stamina)
    {
        if (curTime <= 0)
        {
             if (Input.GetKeyDown(KeyCode.Space))
             {
                moveSpeed = 10.0f;
                playerStamina = playerStamina - stamina;
                curTime = coolTime;
                
                if(playerStamina <= 0)
                {
                    // ´ë½¬ x
                }
            }
             else
             {
                moveSpeed = 4.0f;
             }
        }
        else
        {
            curTime -= Time.deltaTime;
        }
            
    }
    
}
