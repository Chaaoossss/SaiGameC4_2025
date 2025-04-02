using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private void Start()
    {
        EnemyName();
        RandomStatus();
        HpMadness();
    }

    private void Update()
    {
        IsDead();
        HpMadness();
        RegenHP();
    }

    // 5 Enemies variables

    //variables 1 
    protected int maxHealth = 100;
    //variables 2
    protected int healthRegen = 1;
    //variables 3 
    protected int currentHealth = 80;
    //variables 4 
    protected float regenTimer = 0f;
    //variables 5 
    [SerializeField] public bool madNessMode = false;
    // 5 Enemies methods

    //Method 1
    protected void IsDead()
    {
        if (currentHealth <= 0)
        {
            Debug.Log(transform.name + " is dead");
        }
    }
    //Method 2
    protected void RegenHP()
    {
        if (currentHealth < maxHealth)
        {
            regenTimer += Time.deltaTime;
            if (regenTimer >= 1f)
            {
                currentHealth += healthRegen;
                if (currentHealth > maxHealth)
                {
                    currentHealth = maxHealth;
                }
                regenTimer = 0f;
            }
        }
    }
    //Method 3
    protected void EnemyName()
    {
        Debug.Log("Enemy name: " + transform.name);
    }
    //Method 4
    protected void RandomStatus()
    {
        madNessMode = Random.Range(0, 2) == 0 ? false : true;
        Debug.Log("Madness mode: " + madNessMode);
    }
    //Method 5
    protected void HpMadness()
    {
        if ( this. madNessMode == true )
        {
            healthRegen = 5;
        }
    }
}
