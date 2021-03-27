using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hitPoints = 3;
    public Animator animator;
    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Dying();
    }

    public void TakeDamage(int damage)
    {
        hitPoints -= damage;
        print("damage taken, new hitpoints: " + hitPoints);
    }

    void Dying()
    {
        if (hitPoints < 1)
        {
            animator.SetTrigger("Die");
            print("Enemy dies");
        }
    }
}
