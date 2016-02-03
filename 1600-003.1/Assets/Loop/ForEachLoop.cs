using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		string[] strings = new string[3];

		strings [0] = "First string";
		strings [1] = "Second string";
		strings [2] = "Third strings";

		foreach (string item in strings) 
		{
			print (item);
		}
	}
}
	
