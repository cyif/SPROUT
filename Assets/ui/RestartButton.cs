using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {
	public string restart;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick(){
		renwu.restwater = 10;
		GameObject.Find ("WaterInfo").SendMessage ("TransWaterValue", renwu.restwater);
		Application.LoadLevel (restart);
	}
}
