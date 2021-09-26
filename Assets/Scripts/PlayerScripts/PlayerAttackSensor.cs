using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackSensor : MonoBehaviour
{
    [SerializeField]
    CharAttack m_attack;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<MonsterManager>().TakeDamage(m_attack.attackDamage);
            Debug.Log("damage");
        }
    }
}
