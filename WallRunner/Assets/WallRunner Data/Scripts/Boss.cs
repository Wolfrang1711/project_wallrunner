using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    
    public HealthBar healthBar;

    public GameObject gameoverUI;
    public GameObject pausemenu;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        gameoverUI.SetActive(false);
        
    }

    void Update()
    {
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
            gameoverUI.SetActive(true);
            pausemenu.SetActive(true);
            

        }
    }
       
}
