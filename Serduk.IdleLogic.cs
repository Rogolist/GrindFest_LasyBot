
using UnityEngine;
using GrindFest;
//using GrindFest.Isolated;

//public class Ivan.IdleLogic : AutomaticHero
public partial class Serduk
{
	
	public void IdleLogic()
	{
		if (UnityEngine.Input.GetKeyDown(KeyCode.F1))
		{
			DrinkHealthPotion();
		}

		if (Input.GetKeyDown(KeyCode.F2)) // check if use presses the F1 key
		{
			//OpenInventory();

			//var item = FindNearestItem();
			foreach (var item in FindItemsOnGround())
			{
			//if (item != null) Say(item.Name);

			/*
			var bestWeapon = FindItemsOnGround()
				.Where(item => item.Weapon != null)
				.OrderByDescending(item => item.Weapon.MaxDamage)
				.FirstOrDefault();
			if (bestWeapon != null)
			{
			Equip(bestWeapon);
			Say($"Found {bestWeapon.name} with {bestWeapon.Weapon.MaxDamage} damage!");
			}
			*/

			//if (item?.name == "Fireworks") item = null;

				if (item != null) {
					//PickUpItems(item);
					//Say(item.Name);
					PickUp(item);
				}
			}
		}

		if (Input.GetKeyDown(KeyCode.F3))
		{
			
			var rightHand = Equipment[EquipmentSlot.RightHand];
			if (rightHand != null)
			{
				// EquipableBehaviour = Equipment[EquipmentSlot]
				
				//Say($"In my right hand I have {rightHand.name}");// with {rightHand.gameobject.Weapon.MaxDamage} damage, {rightHand.gameobject.Weapon.WeaponType}");
				
				//https://botforgrindfest.com/api/GrindFest.EquipableBehaviour.html
				Say($"In my right hand I have {rightHand.name} with {rightHand.IsEquipped} damage");//, {rightHand.Weapon.Weapon.WeaponType}");
				
				
				//Say($"I've equipped a {weapon.name} with {weapon.Weapon.MaxDamage} damage, {weapon.Weapon.WeaponType}");
				//rightHand.gameobject.Weapon.MaxDamage
			}
			

			//var weapon = Equipment.Weapon;
			//Say($"I've equipped a {weapon.name} with {weapon.Weapon.MaxDamage} damage, {weapon.Weapon.WeaponType}");

			// This is a static method, that means you don't need to have an instance of the class to call it
			//AutomaticParty.PlaceFlag();
			
			// работает, но выбивает ошибку
			/*
			string _needItemName = "Fireworks";
			foreach (var itemInBag in Inventory)
			{
				if (itemInBag.Name == _needItemName)
				{
					//Inventory.RemoveItem(itemInBag);
					Vector3 zero = new Vector3();
					zero = Hero.transform.position;
					itemInBag.DropAround(zero);
				}
			}
			*/
			
			/*
			foreach (var item in FindItemsOnGround()) // We loop over each item we find on the ground
			{
				if (item.Weapon != null) // Check if it's actually a weapon
				{
					if (item.Weapon.MaxDamage > Hero.Equipment.Weapon.MaxDamage) // Check if it's better than the current weapon
					{
						Equip(item);
						//Hero.Say($"I've equipped a {item.name} with {item.Weapon.MaxDamage} damage");
					}
				}
			}
			*/
			
			
		}
		
		/////////////////////////////

		if (Input.GetKeyDown(KeyCode.F4))
		{
			//choosedItemCopy.TakeItemTest();
			
			//float _currentItemDPS = ((Equipment.Weapon.MaxDamage + Equipment.Weapon.MinDamage) / 2 ) * Equipment.Weapon.BaseAttackSpeed;
			//var weapon = Equipment.Weapon;
			//Say($"I've equipped {weapon.name} with {_currentItemDPS} DPS !");
			
			/*
			bool _haveit = false;
			// EquipableBehaviour itemEq
			ItemBehaviour _needItem = new ItemBehaviour();
			//WeaponBehaviour _needItem = new WeaponBehaviour();
			//Item _needItem = new Item();
			//GameObject _needItem = new GameObject();
			string _needItemName = "Stick";
			foreach (var itemInBag in Inventory)
			{
				//Say($"I have a {itemInBag.name}");
				//Say($"It have a {itemInBag.Slot}");
				if (itemInBag.Name == _needItemName) {
					_needItem = itemInBag;
					//Equip(itemInBag);
					_haveit = true;
					}
			}
			
			if (_haveit)
			{
				//Say($"Now I am equipped by {_needItem.Name}");
				//Say($"Damage {_needItem}");
				Equip(_needItem);
			} else {
				//Say($"I have not any {_needItemName}");
			}
			*/
			
		}


	}
}
