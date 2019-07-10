using UnityEngine;
using System.Collections;

public class SetMenu : MonoBehaviour {
	GameObject Menu;
	// Use this for initialization
	void Start () {
		Menu = GameObject.Find ("Menu");
		Menu.SetActive (false);
	}
	
	// Update is called once per frame
	public void OnClickOpen () {
		Menu.SetActive (true);
	}

	public void OnClickClose () {
		Menu.SetActive (false);
	}
}
