using UnityEngine;
using GrindFest;

public partial class Serduk : AutomaticHero
{
	public bool panic;
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