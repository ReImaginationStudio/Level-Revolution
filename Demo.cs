using UnityEngine;
using System.Collections;

public class Demo : MonoBehaviour {
	public int health; 

	void Start ()
	{
		DamagePlayer(15);
	}
	void DamagePlayer(int damage)
	{
		health -= damage;
	}
	void Update ()
	{
		if (health <= 0) {
			health = 0;
			Destroy (gameObject);
			print ("the player be dead. Health: " + health);
		}
		else if (health >= 15) {
			print ("get hit! you be fine!");
		}
		else{
			print ("i don' care");
		}
	}
}