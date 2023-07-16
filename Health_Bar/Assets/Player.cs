using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public int maxHealth = 100;
	public int currentHealth;
	public HealthBar healthBar;

	// oyun ba�lad���nda sa�l�k maximum
	void Start()
    {
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

	// bo�luk u�uyla hasarverir
	// bo�luk tu�uyla g�ncelleme birkere �a�r�l�r
	void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
        {
			TakeDamage(20);
        }
    }

	// hasar� mevcut sa�l�ktan ��kar�yor
	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}
}
