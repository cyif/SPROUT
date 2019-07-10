using UnityEngine;
using System.Collections;

public class SetTeach02 : MonoBehaviour {
	static GameObject Teach;
	// Use this for initialization
	void Start () {
		Teach = GameObject.Find ("Teach02");
		Teach.SetActive (false);
	}
	
	// Update is called once per frame
	static public void SetVisible (bool flag) {
		Teach.SetActive (flag);
	}
}
