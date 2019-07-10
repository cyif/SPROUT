using UnityEngine;
using System.Collections;
using ZJUGame;

public class tukeng : MonoBehaviour {

    bool buse = true;
	public GameObject lizi;
    public GameObject tengman;
    public GameObject tan;
    public GameObject temp;
    public GameObject ladder;
	public GameObject removePlatform = null;


    void getzhongzi(int status)
    {
		if (!buse)
			return;
        if(status == 1)
        {
            //Instantiate(lizi, new Vector3(this.transform.position.x, this.transform.position.y+2.0f, this.transform.position.z), Quaternion.identity);//初始化植物
 //           SavePlants.SaveType(0);
			Debug.Log("qweqweq");
			tengman.gameObject.SetActive(true);
			ladder.gameObject.SetActive (true);
			if (removePlatform)
				removePlatform.gameObject.SetActive (false);
            caozuo.zhongzi = 0;
            buse = false;   //该土坑不可再用
        }
        else if(status == 2)
        {
  //         temp = Instantiate(tan, new Vector3(this.transform.position.x, this.transform.position.y +0.5f, this.transform.position.z), Quaternion.identity) as GameObject;
            //          SavePlants.SaveType(0);
			tan.SetActive(true);
			temp.SetActive (true);
			//tengman.gameObject.GetComponent<Animation>().Play("Take 0010");
        	caozuo.zhongzi = 0;
            buse = false;
        }
        else if(status == 3|| status == 4|| status == 5)  //填上最后一格
        {
 //           SavePlants.SaveType(status);
            caozuo.zhongzi = 0;
            buse = false;
        }
    }

	// Use this for initialization
	void Start () {
		Debug.Log ("asdasdasasd1111111");
//		ladder = GameObject.Find("Ladder");
		ladder.gameObject.SetActive (false);
		tan.gameObject.SetActive (false);
		temp.gameObject.SetActive (false);
//		tengman = GameObject.Find ("tengman1");
		tengman.gameObject.SetActive (false);
		if (removePlatform)
			removePlatform.gameObject.SetActive (true);
		Debug.Log ("asdasdasasd");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
