using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour {
	
	private BaseCharacterPlayer player2 = new BaseCharacterTank();
	private BaseCharacterPlayer player3 = new BaseCharacterSweeper();
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI(){
		GUILayout.Label(player2.CharacterType);
		GUILayout.Label(player3.CharacterType);
	}
}