using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretTargeting : SaiBehavior
{
    [SerializeField] protected Targetable nearestEnemy;
    public Targetable NearestEnemy => this.nearestEnemy;

    [SerializeField] protected List<Targetable> enemies;

    protected virtual void FixedUpdate()
    {
        this.FindNearestEnemy();
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        this.AddEnemy(other);
    }

    protected virtual void OnTriggerExit(Collider other)
    {

        this.RemoveEnemy(other);
    }

    protected virtual void AddEnemy(Collider other)
    {
        Targetable targetable = other.GetComponent<Targetable>();
        if (targetable == null)
        {
            return;
        }
        this.enemies.Add(targetable);
    }

    protected virtual void RemoveEnemy(Collider other)
    {
        Targetable targetable = other.GetComponent<Targetable>();
        if (targetable == null)
        {
            return;
        }
        this.enemies.Remove(targetable);
    }

    protected virtual void FindNearestEnemy()
    {
        if (this.enemies.Count == 0)
        {
            this.nearestEnemy = null;
            return;
        }
        float minDistance = float.MaxValue;
        foreach (Targetable enemy in this.enemies)
        {
            float distance = Vector3.Distance(this.transform.position, enemy.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                this.nearestEnemy = enemy;
            }
        }
    }
}
