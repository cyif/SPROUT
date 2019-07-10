using UnityEngine;
//using UnityEngine.UI;
using System.Collections;

public class SelectLevel : MonoBehaviour {
	static public int unlocked = 3; 
	GameObject[] level = new GameObject[8]; 
	GameObject[] locked = new GameObject[8]; 

	public void OnSelect (string SceneName) {
		Application.LoadLevel (SceneName);
	}

	void Start(){
//		unlocked = 1; //第一关总是开着的
		for (int i = 0; i < 8; i++) {
			level [i] = GameObject.Find ("level" + (i + 1));
			locked [i] = GameObject.Find ("locked" + (i + 1));
		}
	}

	void Update(){
		int i;
		for (i = 0; i < unlocked; i++) {
			level[i].SetActive (true);
			locked[i].SetActive(false);
		}
		for (i = unlocked; i < 8; i++) {
			level[i].SetActive(false);
			locked[i].SetActive(true);
		}
	}
}
