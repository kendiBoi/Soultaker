using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

   public void TakeDamage(int damage)
    {
        SoundManager.PlaySound("Hit");
        currentHealth -= damage;
        if (currentHealth <= 0) Die();
    }
    void Die()
    {
        SoundManager.PlaySound("EnemyDeath");
        transform.position= new Vector3(-100f,-100f,0f);
    }
}
