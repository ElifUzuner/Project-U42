using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public Slider slider;
	public Gradient gradient;
	public Image fill;

	public void SetMaxHealth(int health)
	{
		slider.maxValue = health;
		slider.value = health;

		fill.color = gradient.Evaluate(1f);
		// sa�l�k maximumdayken istenilen renk ye�il olmas� i�in ve 0'dan 1'e kadar olan bi say� atamas� i�in "1f" 
	}

	public void SetHealth(int health)
	{
		slider.value = health;

		fill.color = gradient.Evaluate(slider.normalizedValue);
		// maximum de�erin de�i�ebilir olmas� i�in "normalizedValue"
	}

}
