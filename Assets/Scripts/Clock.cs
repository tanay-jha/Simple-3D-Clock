﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Clock : MonoBehaviour {

	public Transform hoursTransform, minutesTransform, secondsTransform;
	public bool continuous;
	const float degreesPerHour = 30f, degreesPerMinute = 6f, degreesPerSecond = 6f;

	void Update() {										//Awake is a special method in Unity, that is executed before Start() function.
		//Debug.Log(DateTime.Now.Hour);
		if (continuous) {
			UpdateContinuous ();
		} else {
			UpdateDiscrete ();
		}
	}

	void UpdateContinuous() {
		TimeSpan time = DateTime.Now.TimeOfDay;
		hoursTransform.localRotation = Quaternion.Euler (0f, (float)time.TotalHours * degreesPerHour, 0f);
		minutesTransform.localRotation = Quaternion.Euler (0f, (float)time.TotalMinutes * degreesPerMinute, 0f);
		secondsTransform.localRotation = Quaternion.Euler (0f, (float)time.TotalSeconds * degreesPerSecond, 0f);
	}

	void UpdateDiscrete() {
		DateTime time = DateTime.Now;
		hoursTransform.localRotation = Quaternion.Euler (0f, time.Hour * degreesPerHour, 0f);
		minutesTransform.localRotation = Quaternion.Euler (0f, time.Minute * degreesPerMinute, 0f);
		secondsTransform.localRotation = Quaternion.Euler (0f, time.Second * degreesPerSecond, 0f);
	}
	/*// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/
}
