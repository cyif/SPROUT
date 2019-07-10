using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SetWaterInfo : MonoBehaviour {

	private Text RemainWaterValue;
	// Use this for initialization
	void Start () {
		RemainWaterValue = transform.Find ("RemainWater").GetComponent<Text>();
	}

	public void TransWaterValue (int V) {
//		string str = RemainWaterValue.text;
//		int NowV = int.Parse(str);
//		V += NowV;
		RemainWaterValue.text = V.ToString ().PadLeft (2, '0');
	}
}
