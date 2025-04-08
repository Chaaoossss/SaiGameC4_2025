using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoving : MonoBehaviour
{
    [SerializeField] protected Transform TargetToMove;
    [SerializeField] protected NavMeshAgent agent;
    [SerializeField] protected bool isMoving = true;
    [SerializeField] protected Animator animator;
    [SerializeField] protected float targetDistance = 1f;

    protected void Start()
    {
        //this.MoveToTarget();
    }

    protected void FixedUpdate()
    {
        this.MoveToTarget();
        this.UpdateAnimator();
    }

    protected void MoveToTarget()
    {
        if (TargetToMove != null)
        {
            Vector3 position = this.TargetToMove.position;

            this.targetDistance = Vector3.Distance(this.transform.position, position); // Check if the target is within a certain distance
            if (this.targetDistance < 1f)
            {
                this.agent.isStopped = true; // Stop the agent if the target is within the distance
            }
            else
            {
                this.agent.isStopped = false; // Resume movement if the target is out of range
                this.agent.SetDestination(position); // Set the destination of the NavMeshAgent to the target position
            }

        }
    }

    protected void UpdateAnimator()
    {
        if (this.animator != null)
        {
            this.isMoving = !this.agent.isStopped && this.agent.velocity.magnitude > 0.1f;
            this.animator.SetBool("isMoving", this.isMoving); // Update the animator with the movement state
        }
    }
}
