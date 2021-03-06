﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFactory : MonoBehaviour 
{
	[SerializeField]
	private List<GameObject> requiredPrefabs;

	void Awake()
	{
		Application.targetFrameRate = 60;

		foreach (var prefab in requiredPrefabs) 
		{
			Instantiate (prefab);
		}
	}
}
