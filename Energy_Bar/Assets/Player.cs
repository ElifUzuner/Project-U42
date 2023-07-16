using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxEnergy = 100;
    public int currentEnergy;
    public EnergyBar energyBar;

    // oyun ba�lad���nda sa�l�k maximum
    void Start()
    {
        currentEnergy = maxEnergy;
        energyBar.SetMaxEnergy(maxEnergy);
    }

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
        currentEnergy -= damage;

        energyBar.SetEnergy(currentEnergy);
    }
}
