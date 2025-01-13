using UnityEngine;
using GrindFest;
using System;

public partial class Serduk : AutomaticHero
{
	private bool panic;
	private bool debugMode = false;
	private int healCount;
	//private float waitTime = 30f;
	//private float timer = 0.0f;
	//public string location;
	
	/*
	public Dictionary<int, string> slots = new() {
		{1, "Head"},
		{2, "Chest"},
		{3, "Legs"}
	};
	*/
	//		Head = 0	Chest = 1	Legs = 2	LeftFeet = 3	RightFeet = 4	LeftShoulder = 5	RightShoulder = 6	LeftHand = 7	RightHand = 8	LeftGlove = 9	RightGlove = 10	LeftArm = 11	RightArm = 12	Hair = 13	FacialHair = 14	Ring = 15
	
	
	public void Start()
	{
		Debug.Log("Start Ok");
		IsBotting = true;
		
	}

	public void Update()
	{
		if (IsBotting) BottingLogic();
		else IdleLogic();
	}
	
	private void OnGUI()
	{
		var screenPos = Camera.main.WorldToScreenPoint(transform.position + Vector3.up * 3);
		GUI.Label(new Rect(screenPos.x, Screen.height - screenPos.y, 100, 20), $"<color=red>{Health} / {MaxHealth}</color>");
		GUI.Label(new Rect(screenPos.x/2, Screen.height - 200, 100, 20), $"<color=green>Vials - {healCount}</color>");
	}
	
}
