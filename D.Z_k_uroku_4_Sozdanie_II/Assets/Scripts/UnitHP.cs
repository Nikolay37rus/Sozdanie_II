using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitHP : MonoBehaviour
{

	[SerializeField] private float health = 100;
	[SerializeField] public Slider slider;

	public float currentHealth
	{
		get { return health; }
	}

	public void Adjust(float value)
	{
		health += value;

		if (health <= 0)
		{
			Destroy(gameObject);
		}
	}
	void Update()
	{
		slider.value = health;
	}
}