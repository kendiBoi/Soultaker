using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCombat : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Health healthBar;

    public Animator animator;
    public Transform attackPoint;
    public float attackRange;
    public LayerMask enemyLayers;
    public int DamageAmount;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            Attack();
        }
    }

    void Attack()
    {
        SoundManager.PlaySound("Attack");
        animator.SetTrigger("Attack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D Enemy in hitEnemies)
        {
            Enemy.GetComponent<Enemy>().TakeDamage(DamageAmount);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
    }
    
    public void TakeDamage(int damage)
    {
        SoundManager.PlaySound("Hit");
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth <= 0) Die();
    }

    private void Die()
    {
        SoundManager.PlaySound("PlayerDeath");
        SceneManager.LoadScene("EndScene");
    }
}
