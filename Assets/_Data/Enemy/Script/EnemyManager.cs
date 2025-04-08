using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyManager : SaiBehavior
{
    [SerializeField] public List<EnemyCtrl> enemies;
    [SerializeField] public List<EnemyCtrl> sortedEnemies;
    public EnemyCtrl minEnemy;
    public EnemyCtrl maxEnemy;

    private void Start()
    {
        this.ShowEnemies();
        this.FindMinEnemy();
        this.FindMaxEnemy();
        this.SortEnemyList();
    }

    protected override void LoadComponents()
    {
        this.LoadEnemies();
    }

    protected void LoadEnemies()
    {
        EnemyCtrl enemyCtrl;
        enemies = new List<EnemyCtrl>();
        // Load all enemy components from child objects
        // and add them to the enemies list
        // This is a simple example, in a real game you might want to use a more complex system
        foreach (Transform child in this.transform)
        {
            enemyCtrl = child.GetComponent<EnemyCtrl>();
            if (enemyCtrl != null)
            {
                enemies.Add(enemyCtrl);
            }
        }

        Debug.Log("Enemies loaded: " + enemies.Count);
    }

    void ShowEnemies()
    {
        foreach (EnemyCtrl enemy in enemies)
        {
            Debug.Log(enemy.name + ": " + enemy.weight);
        }
    }

    void FindMinEnemy()
    {
        if (enemies.Count == 0)
        {
            Debug.Log("No enemies to compare.");
            return;
        }
        minEnemy = enemies[0];
        foreach (EnemyCtrl enemy in enemies)
        {
            if (enemy.weight < minEnemy.weight)
            {
                minEnemy = enemy;
            }
        }
        Debug.Log("Min Enemy: " + minEnemy.name + ": " + minEnemy.weight);
    }

    void FindMaxEnemy()
    {
        if (enemies.Count == 0)
        {
            Debug.Log("No enemies to compare.");
            return;
        }
        maxEnemy = enemies[0];
        foreach (EnemyCtrl enemy in enemies)
        {
            if (enemy.weight > maxEnemy.weight)
            {
                maxEnemy = enemy;
            }
        }
        Debug.Log("Max Enemy: " + maxEnemy.name + ": " + maxEnemy.weight);
    }

    void SortEnemyList()
    {
        sortedEnemies = enemies
            .OrderBy(enemy => enemy.weight)
            .ToList();
        Debug.Log("Enemies sorted by weight:");
    }

}
