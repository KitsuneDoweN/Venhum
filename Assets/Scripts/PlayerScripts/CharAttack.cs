using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAttack : MonoBehaviour
{
    private Rigidbody2D m_rigid;

    private float curTime;
    private float coolTime = 0.5f;

    public float attackDamage = 1;
    public GameObject attackObject;

    public void Init(Rigidbody2D rigid)
    {
        m_rigid = rigid;
    }

    public void Attack(){
        if (curTime <= 0)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                attackObject.SetActive(true);
                curTime = coolTime;
            }
            else
            {
                attackObject.SetActive(false);

            }
        }
        else
        {
            curTime -= Time.deltaTime;
        }
    }
}
