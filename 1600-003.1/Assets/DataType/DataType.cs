﻿using UnityEngine;
using System.Collections;

public class DataType : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		//Value type variable
		Vector3 pos = transform.position;
		pos = new Vector3(0, 2, 0);

		//Reference type varibale
		Transform tran = transform;
		tran.position = new Vector3(0, 2, 0);
	}
}
