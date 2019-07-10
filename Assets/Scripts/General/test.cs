using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
    public GameObject jump;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.J))
        {
            GameObject b = Instantiate(jump, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
            b.gameObject.GetComponent<Animation>().Play("Take 0010");
        }
	}
}
