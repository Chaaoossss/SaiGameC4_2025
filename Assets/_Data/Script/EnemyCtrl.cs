using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : SaiBehavior
{
    int currentHP = 10;
    int maxHP = 1000;
    public float weight = 1f;
    string enemyName = "";

    private void Awake()
    {
        this.GetRandomWeight();
    }

    bool isDead()
    {
        return currentHP <= 0;
    }

    bool isAlive()
    {
        return currentHP > 0;
    }

    int GetCurrentHP()
    {
        return currentHP;
    }

    float GetRandomWeight()
    {
        weight = Random.Range(0.1f, 10f);
        return weight;
    }

}
