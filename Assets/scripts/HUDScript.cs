using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

	float playerScore = 0;

	// Update is called once per frame
	void Update () {
		playerScore += Time.deltaTime;
	}

	public void increaseScore(int amount){
		playerScore += amount;
	}

	void OnGUI(){
		GUI.skin.label.fontSize = 25;
		GUI.contentColor = Color.black;
		GUI.Label (new Rect (10, 10, 520, 100), "Score: " + (int)(playerScore * 100));
	}

}
