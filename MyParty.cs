using UnityEngine;
using GrindFest;

public class MyParty : AutomaticParty
{
	/*
	public List<HeroController> _heroes { get; };
	public int MaxHeroes { get; }
	*/
	
    public override void OnAllHeroesDied()
    {
        CreateHero("Serduk", "Hero");
    }
	
	/*
	void Upgrade()
	{
		if(_heroes < MaxHeroes)
		{
			CreateHero("Grim", "Hero");
		}
	}
	*/
}

/*
using GrindFest;
using UnityEngine;

class MyParty : AutomaticParty
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SelectedHero.OpenInventory();
        }
    }
}

*/







/*
public class MyParty : AutomaticParty
{
	
	private bool _everioneDead = true;
	
	void Upgrade()
	{
		
		//if(SelectedHero != null)
		//{
		//	SelectedHero.Say("Hello !");
		//}
		
		if(_everioneDead)
		{
			CreateHero("Omen", "Hero");
			_everioneDead = false;
		}
	
	}
*/	
	
	/*
    public override void OnAllHeroesDied()
    {
        _everioneDead = true;
		//CreateHero("Omen", "Hero");//, automaticHeroClass);
    }
	*/
	
	
	/*
	public override void OnAllHeroesDied()
        {
            Invoke(nameof(CreateDefaultHero), 3); // invokes after 3 seconds
        }

	public void CreateDefaultHero()
	{
		var hero = CreateHero("Hero", "Hero");
	}
	*/
		
		
	/*
	public override void OnGameStarted()
    {
        base.OnGameStarted();
        CreateHero("Grim", "Hero");
    }
    public override void OnAllHeroesDied()
    {
        CreateHero("Grim", "Hero");
    }
	*/
	
//}