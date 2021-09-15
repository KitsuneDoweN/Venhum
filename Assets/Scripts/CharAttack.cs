using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAttack : MonoBehaviour
{
    [SerializeField]
    float speed = 3;
    private Rigidbody2D m_rigid;

    private float curTime;
    [SerializeField]
    private float coolTime = 0.5f;

    public void Init(Rigidbody2D rigid)
    {
        m_rigid = rigid;
    }

    public void Attack(){
        if (curTime <= 0)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                curTime = coolTime;
            }
        }
        else
        {
            curTime -= Time.deltaTime;
        }
    }
}
