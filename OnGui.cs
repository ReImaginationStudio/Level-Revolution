using UnityEngine;
using System.Collections;

public class OnGui : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}


	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
		GUI.Box(new Rect( 5, 10, 740, 315), "Main Menu");
		GUI.Box (new Rect (120, 25, 200, 140), "Game 1");
		GUI.Box (new Rect ( 428, 25, 200, 140), "Game 2");
		GUI.Box (new Rect (120, 175, 200, 140), "Game 3");
		GUI.Box (new Rect ( 428, 175, 200, 140), "Game 4");
		if (GUI.Button (new Rect (335, 50, 80, 20), "New Game")) {
			Application.LoadLevel (1);
		}
		else if (GUI.Button (new Rect (335, 100, 80, 20), "Load Game")) {
			Application.LoadLevel (2);
		} 
		else if (GUI.Button (new Rect (335, 150, 80, 20), "Minigames")) {
			Application.LoadLevel (3);
		} 
		else if (GUI.Button(new Rect(335, 200, 80, 20), "MP3 Player")) {
					Application.LoadLevel(4);
		}
		else if (GUI.Button(new Rect(335, 250, 80, 20), "Options")) {
			Application.LoadLevel(4);
		}
	}
}