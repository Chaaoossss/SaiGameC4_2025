using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShooting : SaiBehavior
{
    [SerializeField] protected Targetable target;
    [SerializeField] protected TurretCtrl ctrl;
    [SerializeField] protected float rotationSpeed = 5f;
    [SerializeField] protected float fireRate = 1f; // Shots per second
    [SerializeField] protected int currentFirePoint = 0;

    public Transform bulletPrefab;

    protected override void Start()
    {
        base.Start();
        this.TargetLoading();
        this.Shooting();
    }

    protected virtual void FixedUpdate()
    {
        if (this.target == null)
        {
            return;
        }
        this.Looking();
    }

    protected virtual void Looking()
    {
        if (this.target == null)
        {
            return;
        }

        Vector3 directionToTarget = this.target.transform.position - this.ctrl.Rotator.position;
        Vector3 newDirection = Vector3.RotateTowards(this.ctrl.Rotator.forward, directionToTarget, rotationSpeed * Time.fixedDeltaTime, 0f);
        this.ctrl.Rotator.rotation = Quaternion.LookRotation(newDirection);
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTurretCtrl();
    }

    protected virtual void LoadTurretCtrl()
    {
        if (this.ctrl != null)
        {
            return;
        }
        this.ctrl = transform.parent.GetComponent<TurretCtrl>();
        Debug.Log(transform.name + " TurretCtrl loaded", gameObject);
    }

    protected virtual void TargetLoading()
    {
        Invoke(nameof(this.TargetLoading), 1f);

        this.target = this.ctrl.Target.NearestEnemy;
    }

    protected virtual void Shooting()
    {
        Invoke(nameof(this.Shooting), this.fireRate + Random.Range(-0.1f, 0.1f));

        if (this.target == null)
        {
            return;
        }

        FirePoint firePoint = this.GetFirePoint();
        Vector3 rotatorDirection = this.ctrl.Rotator.transform.forward;

        Transform newBullet = Instantiate(this.bulletPrefab, firePoint.transform.position, Quaternion.identity);
        transform.rotation = Quaternion.LookRotation(rotatorDirection.normalized);

        Debug.Log("Shooting at target: " + this.target.name);
    }

    protected virtual FirePoint GetFirePoint()
    {
        if (this.ctrl.FirePoints.Count == 0)
        {
            return null;
        }

        FirePoint firePoint = this.ctrl.FirePoints[this.currentFirePoint];
        this.currentFirePoint++;
        if (this.currentFirePoint == this.ctrl.FirePoints.Count)
        {
            this.currentFirePoint = 0;
        }
        return firePoint;
    }

    }
