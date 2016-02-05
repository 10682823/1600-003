using UnityEngine;
using System.Collections;

public class AnotherClass : MonoBehaviour
{
	public int cheerios;
	public int fruitloops;


	private int cat;
	private int dog;


	public void Cereal (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log ("Cereal total: " + answer);
	}

	private void Animals (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log ("Animal total: " + answer);
	}
}

