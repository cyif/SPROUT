using UnityEngine;
using System.Collections;

public class SaveThePlant : MonoBehaviour {
	GameObject[] Plants = new GameObject[8];

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 3; i++) {
			Plants [i] = GameObject.Find ("SavePlant/Plant0" + (i + 1));
			Plants [i].SetActive(false);
		}
	}
	
	// Update is called once per frame
	void SaveType (int id) { //0 = empty， 其他是编号
		for (int i = 0; i < 0; i++) {
			if(i == id-1)
				Plants[i].SetActive (true);
			else 
				Plants[i].SetActive(false);
		}
	}
}
