using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private CharAttack m_attack;
    private CharMove m_move;
    private Rigidbody2D rigid;

    public float playerHp = 100.0f;
    void Init()
    {
        m_attack = GetComponent<CharAttack>();
        m_move = GetComponent<CharMove>();
        rigid = GetComponent<Rigidbody2D>();

        m_attack.Init(rigid);
        m_move.Init(rigid);
    }
    
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        m_move.Move();
        m_attack.Attack();
        m_move.Dash();
    }
    public void TakeDamage(float damage)
    {
        playerHp = playerHp - damage;
    }
}
