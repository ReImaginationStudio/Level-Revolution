using UnityEngine;
using System.Collections;

public class BasePlayerMain {
	
	private string playerType;
	private int playerLevel;
	private BaseCharacterPlayer mainPlayer;
	private int attack;
	private int defense;
	private int distant_Attack;
	private int distant_Defense;
	private int speed;
	private int health;
	private int double_attack;
	
	public string Player_Type{
		get{return playerType;}
		set{playerType = value;}
	}
	public int PlayerLevel{
		get{return playerLevel;}
		set{playerLevel = value;}
	}
	public BaseCharacterPlayer MainPlayer{
		get{return mainPlayer;}
		set{mainPlayer = value;}
	}    
	public int Attack{
		get{return attack;}
		set{attack = value;}
	}    
	public int Defense{
		get{return defense;}
		set{defense = value;}
	}
	public int Distant_Attack{
		get{return distant_Attack;}
		set{distant_Attack = value;}
	}    
	public int Distant_Defense{
		get{return distant_Defense;}
		set{distant_Defense = value;}
	}
	public int Speed{
		get{return speed;}
		set{speed = value;}
	}    
	public int Health{
		get{return health;}
		set{health = value;}
	}
	
}