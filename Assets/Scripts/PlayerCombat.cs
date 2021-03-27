using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public bool EnemyCollision = false;
    public Enemy EnemyCollided;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
        EnemyCollided.TakeDamage(1);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EnemyCollision = true;
            print("collision");
            EnemyCollided = other.gameObject.GetComponent<Enemy>();//.TakeDamage(1);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            EnemyCollision = false;
            EnemyCollided = null;
            print("no collision");
        }
    }
}
