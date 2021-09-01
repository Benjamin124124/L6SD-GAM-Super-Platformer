using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 4;
    public int currentHealth;

    void Start()
    {
        // Set health to max value at the beginning
        currentHealth = maxHealth; 
    }

    void Update() 
    {
        
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    void Died()
    {
        if (currentHealth == 0)
        {
            
        }
    }
}
