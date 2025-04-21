using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretCtrl : SaiBehavior
{
    [SerializeField] protected TurretTargeting target;
    public TurretTargeting Target => this.target;

    [SerializeField] protected Transform model;
    [SerializeField] protected Transform rotator;
    public Transform Rotator => this.rotator;

    [SerializeField] protected List<FirePoint> firePoints;
    public List<FirePoint> FirePoints => this.firePoints;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTurretTargeting();
        this.LoadModel();
        this.LoadFirePoints();
    }

    protected virtual void LoadTurretTargeting()
    {
        if (this.target != null)
        {
            return;
        }

        this.target = this.GetComponentInChildren<TurretTargeting>();
        Debug.Log(transform.name + " TurretTargeting loaded", gameObject);
    }

    protected virtual void LoadModel()
    {
        if (this.model != null)
            { return; }
        this.model = transform.Find("Model");
        this.rotator = this.model.Find("Rotator");
        Debug.Log(transform.name + ": Load Model", gameObject);
    }

    protected virtual void LoadFirePoints()
    {
        if (this.firePoints.Count > 0)
        {
            return;
        }
        this.firePoints = new List<FirePoint>(this.GetComponentsInChildren<FirePoint>());
        Debug.Log(transform.name + ": Load FirePoints", gameObject);
    }

}
