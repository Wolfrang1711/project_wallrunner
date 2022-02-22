using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHel : MonoBehaviour
{
	public float maxHealth = 100f;
	public float currentHealth;
	
	public HealthBar healthBar;

	void Start()
	{
		currentHealth = 50f;
		healthBar.SetMaxHealth(maxHealth);
	}

	void Update()
	{
		healthBar.SetHealth(currentHealth);

		if (currentHealth <= 0)
		{
			SceneManager.LoadScene("MainScene");
		}
	}

	
}
