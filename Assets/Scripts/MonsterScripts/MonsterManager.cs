using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    public float monsterHp = 10.0f;
   
    public void TakeDamage(float damage)
    {
        monsterHp = monsterHp - damage;
        if(monsterHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
