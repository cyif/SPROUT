using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public AnimationCurve curve;
    float scale = 0;
 
    // Use this for initialization
    void Start () {
        scale = curve.Evaluate(Time.time / 2f) * 2f;  //按函数成长
        this.transform.localScale = new Vector3(1, scale, 1);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
