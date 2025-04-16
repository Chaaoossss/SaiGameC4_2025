using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoving : SaiBehavior
{
    //[SerializeField] protected Transform TargetToMove;
    [SerializeField] protected Point pointToGo;
    [SerializeField] protected EnemyCtrl enemyCtrl;
    [SerializeField] protected bool isMoving = true;
    [SerializeField] protected float targetDistance = 1f;
    [SerializeField] protected float stopDistance = 1f;

    protected void Start()
    {
        //this.MoveToTarget();
    }

    protected void FixedUpdate()
    {
        this.MoveToTarget();
        this.UpdateAnimator();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadEnemyCtrl();
    }

    protected virtual void LoadEnemyCtrl()
    {
        if (this.enemyCtrl != null)
        {
            return;
        }
        this.enemyCtrl = transform.parent.GetComponent<EnemyCtrl>();
        Debug.LogWarning(transform.name + ": Load EnemyCtrl", gameObject);
    }

    //protected void LoadTargetToMove()
    //{
    //    if (this.TargetToMove != null)
    //    {
    //        return;
    //    }
    //    this.TargetToMove = GameObject.Find("TargetToMove").transform; // Find the target to move in the scene
    //    Debug.LogWarning(transform.name + ": Load TargetToMove", gameObject);
    //}

    protected virtual void MoveToTarget()
    {
        if (pointToGo == null) return;

            Vector3 position = this.pointToGo.transform.position;

            this.targetDistance = Vector3.Distance(this.transform.position, position); // Check if the target is within a certain distance
            if (this.targetDistance < this.stopDistance)
            {
                this.enemyCtrl.Agent.isStopped = true; // Stop the agent if the target is within the distance
                this.LoadNextPoint(); // Load the next point to move to
            }
            else
            {
                this.enemyCtrl.Agent.isStopped = false; // Resume movement if the target is out of range
                this.enemyCtrl.Agent.SetDestination(position); // Set the destination of the NavMeshAgent to the target position
            }

        
    }

    protected virtual void UpdateAnimator()
    {
        if (this.enemyCtrl.Animator != null)
        {
            this.isMoving = !this.enemyCtrl.Agent.isStopped && this.enemyCtrl.Agent.velocity.magnitude > 0.1f;
            this.enemyCtrl.Animator.SetBool("isMoving", this.isMoving); // Update the animator with the movement state
        }
    }

    protected virtual void LoadNextPoint()
    {

            this.pointToGo = this.pointToGo.NextPoint; // Load the next point to move to

    }
}
