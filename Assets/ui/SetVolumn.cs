using UnityEngine;
using System.Collections;

public class SetVolumn : MonoBehaviour {
	GameObject Volumn;
	bool IsOpen;
	double Value;
	// Use this for initialization
	void Start () {
		Volumn = GameObject.Find ("VolumnSlider");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
