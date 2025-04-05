using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaiBehavior : MonoBehaviour
{
    protected void Awake()
    {
        this.LoadComponents();
    }

    protected void Reset()
    {
        
        this.LoadComponents();
    }

    protected virtual void LoadComponents()
    {
        // For overide in child classes
    }
}
