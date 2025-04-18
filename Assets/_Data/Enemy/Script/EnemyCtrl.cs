using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCtrl : SaiBehavior
{
    [SerializeField] protected NavMeshAgent agent;
    [SerializeField] protected Animator animator;

    public NavMeshAgent Agent => agent;
    public Animator Animator => animator;

    int currentHP = 10;
    public float weight = 1f;

    protected override void Awake()
    {
        base.Awake();
        this.GetRandomWeight();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadAgents();
        this.LoadAnimator();
    }


    protected void LoadAgents()
    {
        if (this.agent != null)
        {
            return;
        }

        this.agent = GetComponent<NavMeshAgent>();

        Debug.LogWarning(transform.name + ": Load Agent", gameObject);
    }

    protected void LoadAnimator()
    {
        if (this.animator != null)
        {
            return;
        }
        this.animator = transform.Find("Model").GetComponent<Animator>();
        Debug.LogWarning(transform.name + ": Load Animator", gameObject);
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
