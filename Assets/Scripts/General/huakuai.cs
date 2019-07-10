using UnityEngine;
using System.Collections;

public class huakuai : MonoBehaviour {

    float speed = 0.5f;

    void OntriggerEnter(Collider other)
    {
        speed = -speed;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += new Vector3(0, 0, speed);
	}
}
