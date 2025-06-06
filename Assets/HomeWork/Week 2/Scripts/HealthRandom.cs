using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthRandom : MonoBehaviour
{
    //----------------------Edit below here --------------------
    public Slider slider;
    public int maxHealth = 100;
    public int minHealth = 0;
    public int currentHealth = 0;
    //----------------------Edit above here --------------------
    public void Start()
    {
        slider.minValue = minHealth;
        slider.maxValue = maxHealth;
    }

    // On Click function
    public void OnClick()
    {
        RandomHealth();
    }

    //----------------------Edit below here --------------------
    public void RandomHealth()
    {
        currentHealth = Random.Range(minHealth, maxHealth);
        slider.value = currentHealth;
        Debug.Log("Current Health: " + currentHealth);
    }
}
