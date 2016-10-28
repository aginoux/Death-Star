using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	[SerializeField]
	public int score = 0;

	void Update () {
        gameObject.GetComponent<Text>().text = score.ToString();
	}

    int getScore()
    {
        return score;
    }

	void increaseScore(int add_score){
		score += add_score;
	}
}
