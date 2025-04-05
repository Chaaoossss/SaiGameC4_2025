using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{
    //----------------------Edit below here --------------------
    public Enemy FindEnemyWithSmallestHealth()
    {
        Enemy smallestEnemy = null;
        int smallestHealth = int.MaxValue;
        foreach (Enemy enemy in FindObjectsOfType<Enemy>())
        {
            if (enemy.currentHealth < smallestHealth)
            {
                smallestHealth = enemy.currentHealth;
                smallestEnemy = enemy;
            }
        }

        return null;

    }

    public Enemy FindEnemyWithLargestHealth()
    {
        Enemy largestEnemy = null;
        int largestHealth = int.MinValue;
        foreach (Enemy enemy in FindObjectsOfType<Enemy>())
        {
            if (enemy.currentHealth > largestHealth)
            {
                largestHealth = enemy.currentHealth;
                largestEnemy = enemy;
            }
        }
        return null;
    }

    //----------------------Edit above here --------------------
}
