using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaiBehavior : MonoBehaviour
{
    protected virtual void Start()
    {
        // For overide in child classes
    }

    protected virtual void Awake()
    {
        this.LoadComponents();
    }

    protected virtual void Reset()
    {
        
        this.LoadComponents();
    }

    protected virtual void LoadComponents()
    {
        // For overide in child classes
    }
}
