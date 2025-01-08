using UnityEngine;
using GrindFest;

public partial class Serduk : AutomaticHero
{
	private bool panic;
	private bool debugMode = false;
	private float waitTime = 30f;
	private float timer = 0.0f;
	//public string location;
	
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
}