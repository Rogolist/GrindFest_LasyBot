//using System;
//using System.Collections;//.Generic;
using UnityEngine;
using GrindFest;
//using GrindFest.Isolated;

//public class Ivan.BottingLogic : AutomaticHero
public partial class Serduk
{
	public void BottingLogic()
	{
		
		StatCompositor();



		int _healCount = 0;
		// for GUI count 
		foreach (var item in Inventory)
		{
			if (item?.name != "Vial of Health") _healCount++;
		}
		healCount = _healCount;
		
		//timer += Time.deltaTime;
		
		//var _lvl = Character.Level; // this.Character
		var _lvl = Character.Level.Level;
		//Say($"My level is {_lvl}");
		
		
		//RunToNextArea();
		if (Health < MaxHealth * 0.3) panic = true;
		if (Health > MaxHealth * 0.8) panic = false;
		
		/*
		//if (CurrentArea.Root.name != "Stony Plains") {
		if (CurrentArea?.Root.Name != "Stony Plains")//Crimson Meadows
        {
			Say("Run to Stony Plains");
            GoToArea("Stony Plains");
		*/
		
		//if (CurrentArea != null) {
		//	this.current_area = CurrentArea.Root.name;
		//}

		if (CurrentArea?.Root.name == null) {
			GoToArea("Stony Plains");
			return;
		} else {
			// force to go to Stony Plains as we are in another area and under level 10
			if (Level < 6 && CurrentArea.Root.name != "Stony Plains")
			{    
				GoToArea("Stony Plains"); // stops at the red sign
				Debug.Log(CurrentArea.Root.name); // prints "Crimson Meadows"
				return;
			}
			else if (Level >= 6 && Level < 10 && CurrentArea.Root.name != "Crimson Meadows")
			{    
				GoToArea("Crimson Meadows"); // stops at the red sign
				Debug.Log(CurrentArea.Root.name); // prints "Crimson Meadows"
				return;
			}




		}
		
		
		
		
		
		// идентификация предметов
		// Say ( "Yn Lor " , item.transform )
		

		// https://botforgrindfest.com/api/GrindFest.WorldTile.html
		
		//bool panic;

		//if(CorrectArea())
			
		/*
			{ 1, "Stony Plains" },
			{ 3, "Crimson Meadows" },
			{ 7, "Rotten Burrows" },
			{ 12, "Ashen Pastures" },
			{ 20, "Canyon of Death" },
			{ 24, "Endless Desert" },
		*/
		
		/*
		if (_lvl < 3 && CurrentArea?.Name != "Stony Plains")
		{
			
			if (debugMode) Say($"Run to Stony Plains");
            GoToArea("Stony Plains");
			
		} else if (_lvl >= 3 && _lvl < 7 && CurrentArea?.Name != "Crimson Meadows")
		{
			if (debugMode) Say($"Run to Crimson Meadows");
            GoToArea("Crimson Meadows");
		*/
			
		//} else 
		
	
		if (panic)
		{
			if (debugMode) Debug.Log("panic");
			RunAway();
		// item.gameobject to get the gameobject where this component is, and then item.gameobject.GetComponent<WhatComponentYouWant>()
		} else if(Equipment.Weapon == null)
		{
			if (debugMode) Debug.Log("Equipment.Weapon");
			EquipWeaponFromInventory();

		} else if (FindNearestItem())
			//if(FindItemsOnGround("", null, null, 5f))
		{
			if (debugMode) Debug.Log("FindItemsOnGround");
			CheckItemsOnGround();


		} else if (FindNearestInteractive("Tomb"))
			// chest tomb bookcase barrel
		{
			if (debugMode) Debug.Log("FindNearestInteractive");
			
			var chest = FindNearestInteractive("Tomb");
			if (chest != null)
			{
				if (InteractWith(chest))
				{
					Say("Found and opened a chest!");
				}
			} else return;
			

		} else if (AttackNearestEnemy())
		{
			if (debugMode) Debug.Log("AttackNearestEnemy");
				
			//} else if (FindNearestEnemy(5f))
			//{
				//var monst = FindNearestEnemy(5f);
				//AttackTarget(monst);

				//Say("No items nearby");
				
				// ЭТО ТУТ НЕ РАБОТАЕТ !!!
				//this.target = this.FindNearestEnemy(6f, 3f);
				//this.Say(target ? $"target found: {target.name}" : "target not found");

				//if (!AttackNearestEnemy()) // AttackNearestEnemy returns true or false based on whether it was able to find some enemy and attack it or not
				//{
					//Say("No Enemy near...");

					//Say("Run !");

					//Attack



		

		} else  {
				
			if (debugMode) Debug.Log("RunAroundInArea");
			RunAroundInArea();

					//Say("Attack !");
				//}

		}
		

	}



	
	////////////////////////////////////////////////////////////////////

	void StatCompositor()
	{
		// stats
		if (StatPoints > 0)
		{
			if (Intelligence < Strength -10)
			{
				BuyStat(Stat.Intelligence, 1);
				return;
			}
			else if (Dexterity < Strength)
			{
				BuyStat(Stat.Dexterity, 1);
				return;
			}
			else
			{
				BuyStat(Stat.Strength, 1);
				return;
			}

		}
	}
	
	////////////////////////////////////////////////////////////////////

	void RunToNextArea()
	{
		//CharacterBehaviour

		
		
		/*
		Dictionary<int, string> Areas = new Dictionary<int, string>()
		{
			{ 1, "Stony Plains" },
			{ 3, "Crimson Meadows" },
			{ 7, "Rotten Burrows" },
			{ 12, "Ashen Pastures" },
			{ 20, "Canyon of Death" },
			{ 24, "Endless Desert" },
		};

		string? targetArea = Areas
		.Where(kvp => heroLevel < kvp.Key && kvp.Value != CurrentArea)
		.Select(kvp => kvp.Value)
		.FirstOrDefault();

		_tree = new BehaviorTreeBuilder(gameObject)
			.Sequence()
				.Selector()
					.Condition(() => targetArea != null)
						.GotoArea(this, targetArea, true);
		*/
		//var hasLowHealth = Health < MaxHealth / 2;
		
		/*
		if (CurrentArea?.Name != "Stony Plains")//Crimson Meadows
        {
			Say("Run to Stony Plains");
            GoToArea("Stony Plains");
        }
		*/
	}
	
	////////////////////////////////////////////////////////////////////
	
	void RunAway()
	{
		if (HasHealthPotion())
		{
			DrinkHealthPotion();
			if (FindNearestEnemy(10f) != null)
				RunAwayFromNearestEnemy(20f);
		}
		else if
			(FindNearestEnemy(10f) != null)
				RunAwayFromNearestEnemy(20f);
	}


	
}
