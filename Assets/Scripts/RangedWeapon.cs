using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : MonoBehaviour
{
    public float speed = 15;
    public float distance;
    public LayerMask isLayer;

    private float weaponDamage = 1;
    private CharAttack m_attack;

    void Start()
    {
        Invoke("DestroyBullet", 2);
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<MonsterManager>().TakeDamage(weaponDamage);
            Debug.Log("damage");
            Destroy(gameObject);
        }
    }
    void Update()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, transform.right, distance, isLayer);
        if(ray.collider != null)
        {
            if(ray.collider.tag == "Enemy")
            {
                Debug.Log("ИэСп");
            }
            Destroy(gameObject);
        }
        if(transform.rotation.y == 0)
        {
            transform.Translate(transform.right * speed * Time.deltaTime); 
        }
        else
        {
            transform.Translate(transform.right * -1 * speed * Time.deltaTime);
        }
    }
    void DestroyBullet()
    {
        Destroy(gameObject);
    }

}
