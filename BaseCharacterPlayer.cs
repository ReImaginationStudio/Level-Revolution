using UnityEngine;
using System.Collections;

public class BaseCharacterPlayer {

	private string characterName;
	private string characterType;
	private string characterDescription;
	private int level;
	private int health;
	private int attack;
	private int defense;
	private int distant_Attack;
	private int distant_Defense;
	private int speed;

	public string CharacterName{
		get{return characterName;}
		set{characterName = value;}
	}
	public string CharacterType{
		get{return characterType;}
		set{characterType = value;}
	}
	public string CharacterDescription{
		get{return characterDescription;}
		set{characterDescription = value;}
	}
	public int Health{
		get{return health;}
		set{health = value;}
	}
	public int Level{
		get{return level;}
		set{level = value;}
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
}	