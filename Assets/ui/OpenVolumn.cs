using UnityEngine;
using System.Collections;

public class OpenVolumn : MonoBehaviour {
	bool Openning;
	GameObject BGM;
	GameObject IMG;
	// Use this for initialization
	void Start () {
		Openning = true;
		BGM = GameObject.Find ("BGM");
		IMG = GameObject.Find ("VolumnOpenButtom");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick(){
		if (Openning) {
			Openning = false;
		} else {
			Openning = true;
		}
		BGM.SendMessage ("OpenOrClose", Openning);
		IMG.SetActive (Openning);
	}
}
