using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControlVictory : MonoBehaviour {
	GameObject[] Stars = new GameObject[3];
	private Text Score;
	int ScoreValue;

	// Use this for initialization
	void Start () {
		ScoreValue = Random.Range(900, 1100);
		Score = GameObject.Find ("ScoreText").GetComponent<Text>();
		for (int i = 0; i < 3; i++) {
			Stars [i] = GameObject.Find ("Star" + (i + 1));
			Stars [i].SetActive(false);
		}
		Score.text = ScoreValue.ToString ().PadLeft (4, '0');
		if (ScoreValue > 1000)
			Stars [2].SetActive (true);
		if (ScoreValue > 300)
			Stars [1].SetActive (true);
		Stars [0].SetActive (true);
	}

	public void setScore(int V){
		ScoreValue = V;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
