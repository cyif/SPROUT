using UnityEngine;
using System.Collections;

public class SetTeach01 : MonoBehaviour {
	static GameObject Teach;
	// Use this for initialization
	void Start () {
		Teach = GameObject.Find ("Teach01");
		Teach.SetActive (false);
	}

//	static public bool flag;
	// Use this for initialization
		
	// Update is called once per frame
	static public void SetVisible (bool flag) {
		Debug.Log ("Visible : " + flag);
		Teach.SetActive (flag);
	}
}

