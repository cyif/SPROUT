using UnityEngine;
using System.Collections;

public class SelectLevelButtom : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick(){
		Application.LoadLevel ("02-chapter");
	}
}
