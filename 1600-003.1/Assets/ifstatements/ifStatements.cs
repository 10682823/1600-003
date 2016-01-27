using UnityEngine;
using System.Collections;

public class ifStatements : MonoBehaviour 

{
	public float coffeeTemperture = 85.0f;
	public float hotLimitTemperture = 70.0f;
	public float coldLimitTemperture = 40.0f;

	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TempertureTest();

		coffeeTemperture -= Time.deltaTime * 5f;
	}

	void TempertureTest ()
	{
		if(coffeeTemperture > hotLimitTemperture)
		{
			print("Coffee is too hot.");
		}

		else if(coffeeTemperture < coldLimitTemperture)
		{
			print("Coffee is too cold.");
		}

		else
		{
			print("Coffee is perfect.");
		}
	}
}
