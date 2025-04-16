using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : SaiBehavior
{
    [SerializeField] protected Point nextPoint;

    public Point NextPoint => nextPoint;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadNextPoint();
    }

    protected virtual void LoadNextPoint()
    {
        Transform parent = this.transform.parent;
        if (parent == null)
        {
            return ;
        }

        int index = this.transform.GetSiblingIndex();
        int siblingCount = parent.childCount;

    if (index + 1 < siblingCount)
        {
            Transform nextPoint = parent.GetChild(index + 1);
            Point next = nextPoint.GetComponent<Point>();
            if (next != null)
            {
                this.nextPoint = next;
                return;
            }
            return;
        }
        return;


    }
}
