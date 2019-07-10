using UnityEngine;
using System.Collections;

public class SetBGM : MonoBehaviour {
	public AudioSource BGM;

	// Use this for initialization
	void Start () {
		BGM = GameObject.Find("BGM").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetValue(float f){
		BGM.volume = f;
	}

	public void OpenOrClose(bool flag){
		BGM.mute = !flag;
	}
}
