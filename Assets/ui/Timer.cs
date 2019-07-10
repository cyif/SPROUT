using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	private int minite = 0;
	private int second = 0;
	private int timeInt = 0;
	private float timer = 0;
	private string s;
	private Text timevalue;

	// Use this for initialization
	void Start () {
		timevalue = transform.Find ("timedis").GetComponent<Text>();
	}
		
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		timeInt = (int)timer;
		minite = timeInt / 60;
		second = timeInt % 60;
		timevalue.text = minite.ToString().PadLeft(2, '0') + " : " + second.ToString().PadLeft(2, '0');
	}
}
