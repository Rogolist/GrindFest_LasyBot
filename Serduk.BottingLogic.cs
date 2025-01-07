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
		//var _lvl = Character.Level; // this.Character
		var _lvl = Character.Level.Level;
		//Say($"My level is {_lvl}");
		
		
		//RunToNextArea();
		if (Health < MaxHealth * 0.3) panic = true;
		if (Health > MaxHealth * 0.8) panic = false;
		
		/*
		if (CurrentArea?.Name != "Stony Plains")//Crimson Meadows
        {
			Say("Run to Stony Plains");
            GoToArea("Stony Plains");
		*/
		
		
		// идентификация предметов
		// Say ( "Yn Lor " , item.transform )
		
		
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
		
		if (_lvl < 3 && CurrentArea?.Name != "Stony Plains")
		{
			
			Say($"<<textColor [“red”]>text with red font</textColor>>Run to Stony Plains");
            GoToArea("Stony Plains");
			
		} else if (_lvl >= 3 && _lvl < 7 && CurrentArea?.Name != "Crimson Meadows")
		{
			Say($"<<textColor [“red”]>>text with red font<</textColor>>Run to Crimson Meadows");
            GoToArea("Crimson Meadows");

		
		
		
		
		
		
		
		
		

		} else if (panic)
		{
			
			//Debug.Log("panic");
			RunAway();

		// item.gameobject to get the gameobject where this component is, and then item.gameobject.GetComponent<WhatComponentYouWant>()
		} else if(Equipment.Weapon == null)
		{
			//Debug.Log("Equipment.Weapon");
			EquipWeaponFromInventory();
		
		} else if (Equipment.Shield == null && Equipment.Weapon.name != "Blacksmithing Hammer" && Equipment.Weapon.name !="Pickaxe" && Equipment.Weapon.name !="Pan" && Equipment.Weapon.name !="Fishing Rod" && Equipment.Weapon.name !="Ladle" && Equipment.Weapon.name !="Shortbow" && Equipment.Weapon.name !="Orcish Spear")
		{
			//Debug.Log("Equipment.Shield");
			EquipShieldFromInventory();
				
		// https://botforgrindfest.com/api/GrindFest.EquipmentSlot.html
		/*		Head = 0	Chest = 1	Legs = 2	LeftFeet = 3	RightFeet = 4	LeftShoulder = 5	RightShoulder = 6	LeftHand = 7	RightHand = 8	LeftGlove = 9	RightGlove = 10	LeftArm = 11	RightArm = 12	Hair = 13	FacialHair = 14	Ring = 15
		*/
		
		} else if(Equipment[EquipmentSlot.Head] == null) // var rightHand = Equipment[EquipmentSlot.RightHand]; - это про слот персонажа
		{
			//Debug.Log("EquipArmorFromInventory");
			EquipArmorFromInventory(EquipmentSlot.Head);

		} else if(Equipment[EquipmentSlot.Chest] == null)
		{
			//Debug.Log("EquipArmorFromInventory");
			EquipArmorFromInventory(EquipmentSlot.Chest);

		} else if(Equipment[EquipmentSlot.Legs] == null)
		{
			//Debug.Log("EquipArmorFromInventory");
			EquipArmorFromInventory(EquipmentSlot.Legs);

		} else if(Equipment[EquipmentSlot.LeftFeet] == null)
		{
			//Debug.Log("EquipArmorFromInventory");
			EquipArmorFromInventory(EquipmentSlot.LeftFeet);

		} else if(Equipment[EquipmentSlot.RightFeet] == null)
		{
			//Debug.Log("EquipArmorFromInventory");
			EquipArmorFromInventory(EquipmentSlot.RightFeet);

		} else if(Equipment[EquipmentSlot.LeftShoulder] == null)
		{
			//Debug.Log("EquipArmorFromInventory");
			EquipArmorFromInventory(EquipmentSlot.LeftShoulder);

		} else if(Equipment[EquipmentSlot.RightShoulder] == null)
		{
			//Debug.Log("EquipArmorFromInventory");
			EquipArmorFromInventory(EquipmentSlot.RightShoulder);

		} else if(Equipment[EquipmentSlot.LeftGlove] == null)
		{
			//Debug.Log("EquipArmorFromInventory");
			EquipArmorFromInventory(EquipmentSlot.LeftGlove);

		} else if(Equipment[EquipmentSlot.RightGlove] == null)
		{
			//Debug.Log("EquipArmorFromInventory");
			EquipArmorFromInventory(EquipmentSlot.RightGlove);

		} else if(Equipment[EquipmentSlot.LeftArm] == null)
		{
			//Debug.Log("EquipArmorFromInventory");
			EquipArmorFromInventory(EquipmentSlot.LeftArm);

		} else if(Equipment[EquipmentSlot.RightArm] == null)
		{
			//Debug.Log("EquipArmorFromInventory");
			EquipArmorFromInventory(EquipmentSlot.RightArm);

		} else if(Equipment[EquipmentSlot.Ring] == null)
		{
			//Debug.Log("EquipArmorFromInventory");
			EquipArmorFromInventory(EquipmentSlot.Ring);




		} else if (FindNearestItem())
			//if(FindItemsOnGround("", null, null, 5f))
		{
			//Debug.Log("FindItemsOnGround");
			CheckItemsOnGround();

		} else if (AttackNearestEnemy())
		{
			//Debug.Log("AttackNearestEnemy");
				
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

		} else {
				
			//Debug.Log("RunAroundInArea");
			RunAroundInArea();

					//Say("Attack !");
				//}

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
	
	public void RunAway()
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

	////////////////////////////////////////////////////////////////////
	
	public void EquipWeaponFromInventory()
	{
					
		//float _maxDPS = -1000f;
		//var _bestWeapon = new ItemBehaviour();
		// найти в инвентаре и надеть оружие
		foreach (var item in Inventory)
		{
			//Say($"I have a {item.name}");
			//Say($"{weapon.name} dps {(weapon.BaseMaxDamage - weapon.BaseMinDamage) * weapon.BaseAttackSpeed}");

			if (item.Weapon != null)// && item.DefaultAttack is Weapon.MeleeAttack) // Required Strenght  WeaponMastery
			//if (weapon.DefaultAttack is MeleeAttack)
			{
				float _itemDPS = ((item.Weapon.MaxDamage + item.Weapon.MinDamage) / 2 ) * item.Weapon.BaseAttackSpeed;
				
				if (Equipment.Weapon != null)
				{
					//float _itemDPS = ((item.Weapon.MaxDamage + item.Weapon.MinDamage) / 2 ) * item.Weapon.BaseAttackSpeed;
					// float DamageRating => ((float)MinDamage + (float)MaxDamage) / 2 * BaseAttackSpeed;
					float _currentItemDPS = ((Equipment.Weapon.MaxDamage + Equipment.Weapon.MinDamage) / 2 ) * Equipment.Weapon.BaseAttackSpeed;
					
					if (_itemDPS > _currentItemDPS)
					{
						//Say($"I've equipped {item.name} with {_itemDPS} DPS !");
						Say($"I've equipped {item.name} with {_itemDPS} DPS ({item.Weapon.WeaponType})");
						Equip(item);
						
						Debug.Log (Equipment.Weapon.WeaponType.ToString()); 
					}
					
				} else {
					//Say($"I've equipped {item.name} !");
					Say($"I've equipped {item.name} with {_itemDPS} DPS ({item.Weapon.WeaponType})");
					Equip(item);
					
					Debug.Log (Equipment.Weapon.WeaponType.ToString()); 
				};
				
				//return;
			}
		}
	}
	
	////////////////////////////////////////////////////////////////////
	
	public void EquipShieldFromInventory()
	{

		foreach (var item in Inventory)
		{
			if (item.Shield != null)
			{
				Say($"I've equipped a {item.name} with {item.Shield.BlockChance} block chance");
				Equip(item);
				//return;
			}

		}

	}
	
	////////////////////////////////////////////////////////////////////
	
	public void EquipArmorFromInventory(EquipmentSlot _slot)
	{
		foreach (var item in Inventory)
		{
			// var rightHand = Equipment[EquipmentSlot.RightHand]; - это про слот персонажа
			// public EquipableBehaviour this[EquipmentSlot slot] { get; }
			//if (item.equipable.Slot.EquipmentSlot[EquipmentSlot.Head] != null)
			if (item.equipable.Slot == _slot)
			{
				Say($"I've equipped a {item.name} at slot {_slot}");// with {item.Shield.BlockChance} block chance");
				Equip(item);
				//return;
			}
		}
	}
	
	////////////////////////////////////////////////////////////////////
	
	public void CheckItemsOnGround()
	{
		foreach (var item in FindItemsOnGround()) // We loop over each item we find on the ground
		{
			//Say(item?.name);

			
			if (item.Weapon != null) // Check if it's actually a weapon
			{
				float _itemDPS = ((item.Weapon.MaxDamage + item.Weapon.MinDamage) / 2 ) * item.Weapon.BaseAttackSpeed;
				
				if (Equipment.Weapon != null)
				{
					float _currentItemDPS = ((Equipment.Weapon.MaxDamage + Equipment.Weapon.MinDamage) / 2 ) * Equipment.Weapon.BaseAttackSpeed;
					
					if (_itemDPS > _currentItemDPS)
					{
						//Say($"I've equipped {item.name} with {_itemDPS} DPS !");
						Say($"I've equipped {item.name} with {_itemDPS} DPS ({item.Weapon.WeaponType})");
						Equip(item);
					} else {
						
					/*
					if (item.Weapon.MaxDamage > Equipment.Weapon.MaxDamage) // Check if it's better than the current weapon
					//item.Weapon.MinDamage
					//item.Weapon.AttackSpeed
					//WeaponType
					{
						Equip(item);
						//Say($"I've equipped a {item.name} with {item.Weapon.MaxDamage} damage");
						Say($"I've equipped a {item.name} with {item.Weapon.MaxDamage} damage, {item.Weapon.WeaponType}");
					} else {
					*/
						
						PickUp(item);
						//Say($"I've equipped a {item.name} with {item.Weapon.MaxDamage} damage, {item.Weapon.WeaponType}");
					}
					
				} else {
					Equip(item);
					Say($"I've equipped a {item.name}");
					}
			}
			
			else if (item?.Shield != null)
			{

				if (Equipment.Weapon.name != "Blacksmithing Hammer" && Equipment.Weapon.name !="Pickaxe" && Equipment.Weapon.name !="Pan" && Equipment.Weapon.name !="Fishing Rod" && Equipment.Weapon.name !="Ladle" && Equipment.Weapon.name !="Shortbow" && Equipment.Weapon.name !="Orcish Spear")
				{
				//enum _wType = 1;
				//if (Equipment.WeaponType != WeaponType.TwoHandedSword)
					//Invalid = -1 Sword = 0 TwoHandedSword = 1 Axe = 2 Mace = 3 Spear = 4 Bow = 5 Crossbow = 6 Gun = 7 Rifle = 8
				//{
					
				// Debug.Log(Equipment.Weapon.WeaponType.ToString());
				
					if (Equipment.Shield != null)
					{
						if (item.Shield.BlockChance > Equipment.Shield.BlockChance)
						{
							Equip(item);
							Say($"I've equipped a {item.name} with {item.Shield.BlockChance} block chance");
						} else PickUp(item);
						
					} else Equip(item);
				
				
				} else {
					PickUp(item);
				}
				
			/*	
			}
			else if (item?.Armor != null)
			{
				if (Equipment.Slots[item.equipable.Slot]?.Item.Armor?.Armor < item.Armor?.Armor)
				{
					Equip(item);
					
				} else {
					PickUp(item);
				}
			*/	
			
			
			/*
			// Equipment.Slots[item.equipable.Slot].Item.Armor
			else if (item?.Equipment[EquipmentSlot.Head] != null)
			{
				// if (Equipment.Slots[item.equipable.Slot]?.Item.Armor?.Armor > item.Armor?.Armor)
				if (item.Armor?.Armor > Equipment[EquipmentSlot.Head]?.Item.Armor?.Armor)
				{
				Equip(item);
				//Say($"I've equipped a {item.name} with {item.Shield.BlockChance} block chance");
				} else PickUp(item);
			}
			*/
			
			}
			else
			{
				PickUp(item);
			}
			
			
			/*
			var itemOnHead = Equipment[EquipmentSlot.Head];
			if (itemOnHead != null)
			{
				Say($"I'm wearing a {itemOnHead.name} on my head");
			}
			*/
			
		}
	}
	
	////////////////////////////////////////////////////////////////////

/*
static bool ShouldEquip(AutomaticHero hero, ItemBehaviour item)
{
    try
    {
        if (item.Weapon != null)
            return ShouldEquip(item.Weapon, item.equipable, hero.Equipment.Weapon, hero.Equipment.Shield);
        else if (item.Shield != null)
            return ShouldEquip(item.Shield, hero.Equipment.Shield);
        else if (item.Armor != null)
            return ShouldEquip(item, hero.Equipment);
        else if (item.equipable.Slot == EquipmentSlot.Ring)
            return ShouldEquipRing(item, hero.Equipment);
    }
    catch (Exception ex)
    {
        Debug.Log($"Failed at {item.Name}: {ex.Message}\n{ex.StackTrace}");
    }

    return false;
}

//Is the shield on the ground (itemShield) better than the equipped shield?
static bool ShouldEquip(ShieldBehaviour itemShield, ShieldBehaviour? heroShield)
{
    if (heroShield == null || (heroShield.TryGetComponent(out DurabilityBehaviour heroDur2) && heroDur2.CurrentDurability == 0))
        return true;

    if (itemShield.BlockAmount * itemShield.BlockChance == heroShield.BlockAmount * heroShield.BlockChance)
    {
        if (itemShield.TryGetComponent(out DurabilityBehaviour itemDur) && heroShield.TryGetComponent(out DurabilityBehaviour heroDur))
            return itemDur.CurrentDurability > heroDur.CurrentDurability;
    }

    return itemShield.BlockAmount * itemShield.BlockChance > heroShield.BlockAmount * heroShield.BlockChance;
}
*/

	
}
