﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMenu : MonoBehaviour 
{
	[SerializeField]
	Canvas parentCanvas;

	public bool IsOpen { get; private set; }

	RectTransform rect;

	void Awake()
	{
		rect = GetComponent<RectTransform> ();
		gameObject.SetActive (false);
	}

	public void Open()
	{
		gameObject.SetActive(true);
		LeanTween.moveX(rect, 0, 0.2f)
			.setEase (LeanTweenType.easeInCubic); 

		IsOpen = true;
	}

	public void Close()
	{
		LeanTween.moveX (rect, -256 * parentCanvas.scaleFactor, 0.2f)
			.setEase (LeanTweenType.easeInCubic)
			.setOnComplete (() => gameObject.SetActive (false));

		IsOpen = false;
	}

	public void SignOut()
	{
		Application.Quit();
	}
}
