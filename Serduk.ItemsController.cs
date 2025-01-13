
using UnityEngine;
using GrindFest;

public partial class Serduk
{
		////////////////////////////////////////////////////////////////////
	
	void EquipWeaponFromInventory()
	{
		//(Equipment.Shield == null && Equipment.Weapon.name != "Blacksmithing Hammer" && Equipment.Weapon.name !="Pickaxe" && Equipment.Weapon.name !="Pan" && Equipment.Weapon.name !="Fishing Rod" && Equipment.Weapon.name !="Ladle" && Equipment.Weapon.name !="Shortbow" && Equipment.Weapon.name !="Orcish Spear")
		// Equipment.Weapon.InteractiveBehaviour.Item, (which i'll rename to Weapon.Interactive as well) you could also do GetComponent<ItemBehaviour>() (which is slow)
					
		//float _maxDPS = -1000f;
		//var _bestWeapon = new ItemBehaviour();
		// найти в инвентаре и надеть оружие
		foreach (var item in Inventory)
		{
			//Say($"I have a {item.name}");
			//Say($"{weapon.name} dps {(weapon.BaseMaxDamage - weapon.BaseMinDamage) * weapon.BaseAttackSpeed}");

			if (item?.Weapon != null && item?.name != "Fishing Rod" && item?.name != "Shortbow")// && item.DefaultAttack is Weapon.MeleeAttack) // Required Strenght  WeaponMastery
			//if (weapon.DefaultAttack is MeleeAttack)
			{
				float _itemDPS = ((item.Weapon.MaxDamage + item.Weapon.MinDamage) / 2 ) * item.Weapon.BaseAttackSpeed; // only for message !!!!
				
				//if (Equipment.Weapon != null)
				//{
					//float _itemDPS = ((item.Weapon.MaxDamage + item.Weapon.MinDamage) / 2 ) * item.Weapon.BaseAttackSpeed;
					// float DamageRating => ((float)MinDamage + (float)MaxDamage) / 2 * BaseAttackSpeed;
					/*
					float _currentItemDPS = ((Equipment.Weapon.MaxDamage + Equipment.Weapon.MinDamage) / 2 ) * Equipment.Weapon.BaseAttackSpeed;
					
					if (_itemDPS > _currentItemDPS)
					{
						//Say($"I've equipped {item.name} with {_itemDPS} DPS !");
						Say($"I've equipped {item.name} with {_itemDPS} DPS ({item.Weapon.WeaponType})");
						Equip(item);
						
						//Debug.Log (Equipment.Weapon.WeaponType.ToString()); 
						if (debugMode) Debug.Log (item.Weapon.WeaponType.ToString()); 
					}
					*/
				//} else {
					//Say($"I've equipped {item.name} !");
					Say($"I've equipped {item.name} with {_itemDPS} DPS ({item.Weapon.WeaponType})");
					Equip(item);
					
						//Debug.Log (Equipment.Weapon.WeaponType.ToString()); 
						if (debugMode) Debug.Log (item.Weapon.WeaponType.ToString());
				//};
				
				return;
			}
		}
		
		//if (Equipment.Weapon != null) EquipBestWeaponFromInventory();
		
		//waitTime = timer + waitTime;
	}

	////////////////////////////////////////////////////////////////////
	
	
	void CheckItemsOnGround()
	{
		// логика
		// 1 все предметы на земле в округе в массиве
		// 2 перебираем по очереди все предметы из массива
		// 3 проверяем для какого слота этот предмет
		// 4 
		
		
		
		
		foreach (var item in FindItemsOnGround()) // We loop over each item we find on the ground
		{
			//foreach (var _slot in slots) // перебираем все возмодные слоты
			//array[] slots = {"Head", "Chest", "Legs"};
			//var[] slots = {Head, Chest, Legs};	// Equipment[EquipmentSlot.Head];
			
			//if(Equipment[EquipmentSlot.LeftShoulder] == null
			
			//foreach (EquipmentSlot _slot in [Equipment[EquipmentSlot.Head], Equipment[EquipmentSlot.Chest], Equipment[EquipmentSlot.Legs]])
			//foreach (EquipmentSlot _slot in Equipment[EquipmentSlot])
			
			//foreach (var _slot in ("Head","Chest")) // перебираем все возмодные слоты
/*		Head = 0	Chest = 1	Legs = 2	LeftFeet = 3	RightFeet = 4	LeftShoulder = 5	RightShoulder = 6	LeftHand = 7	RightHand = 8	LeftGlove = 9	RightGlove = 10	LeftArm = 11	RightArm = 12	Hair = 13	FacialHair = 14	Ring = 15
		*/
			
					/*	
					} else if(Equipment[EquipmentSlot.LeftShoulder] == null && timer > waitTime)
					{
						if (debugMode) Debug.Log("EquipArmorFromInventory LeftShoulder");
						EquipArmorFromInventory(EquipmentSlot.LeftShoulder);
					*/
			
			
			
			
			//{
				/*
				//var _slot = Head;
				if (item?.equipable.Slot == _slot)  // находим нужный слот
				//if (item?.equipable)
				{
					if (Equipment[_slot] == null)		// если аналогичный слот на теле пустой, то сразу надеваем
					{
					
						Say($"I've equipped a {item.name} at slot {_slot}");// with {item.Shield.BlockChance} block chance");
						Equip(item);
						return;
					
					} else 
					*/
					if (item?.Weapon != null && item?.name != "Fishing Rod" && item?.name != "Shortbow")
					{
						
						if (debugMode) Debug.Log("Equipment.Weapon");
						
						float _itemDPS = ((item.Weapon.MaxDamage + item.Weapon.MinDamage) / 2 ) * item.Weapon.BaseAttackSpeed;
						float _currentItemDPS = ((Equipment.Weapon.MaxDamage + Equipment.Weapon.MinDamage) / 2 ) * Equipment.Weapon.BaseAttackSpeed;
						
						if (_itemDPS > _currentItemDPS)
						{
							//Say($"I've equipped {item.name} with {_itemDPS} DPS !");
							Say($"I've equipped {item.name} with {_itemDPS} DPS ({item.Weapon.WeaponType})");
							Equip(item);
							
							//Debug.Log (Equipment.Weapon.WeaponType.ToString()); 
							if (debugMode) Debug.Log (item.Weapon.WeaponType.ToString()); 
						} else {PickUp(item); return;}
						
					} else if (item?.Shield != null && Equipment.Shield == null && Equipment.Weapon?.name != "Blacksmithing Hammer" && Equipment.Weapon?.name !="Pickaxe" && Equipment.Weapon?.name !="Pan" && Equipment.Weapon?.name !="Fishing Rod" && Equipment.Weapon?.name !="Ladle" && Equipment.Weapon?.name !="Shortbow" && Equipment.Weapon?.name !="Orcish Spear")
					{
						if (debugMode) Debug.Log("Equipment.Shield");
						Equip(item);
					/*	
					} else if (item?.Armor.Armor > Equipment[_slot].Armor) {
						
						if (debugMode) Debug.Log("Equipment.Armor");
						Equip(item);
					*/	
					} else {
						PickUp(item);
						return;
					}

				//}

			//}
			
			//Say(item?.name);

			//PickUp(item);

			/*
			if (item.Weapon != null && item?.name != "Fishing Rod" && item?.name != "Shortbow") // Check if it's actually a weapon
			{
				PickUp(item);
				EquipWeaponFromInventory();
				return;

			} else if (item?.Shield != null)
			{
				PickUp(item);
				EquipShieldFromInventory();
				return;	

			} else
			{
				PickUp(item);
			}
			*/
			
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

	/*
	private void OpenChest(ChestBehaviour chest)
	{
		if (chest.Interactive.IsDisabled)
			return;

		chest.StartCoroutine(chest.Open());
		
		//maybe chest.Interactive.OnPlayerClick(Hero) 		or OnPlayerDoubleClick
	}
	*/
	
	
	
}