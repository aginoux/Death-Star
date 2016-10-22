using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	[SerializeField]
	private int score = 0;

	void Update () {
	
	}

	void increaseScore(int add_score){
		score += add_score;
		print ("Score" + score);
	}
}
