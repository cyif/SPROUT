using UnityEngine;
using System.Collections;

public class caozuo : MonoBehaviour {

    static public int zhongzi = 0;  //种子类别
    static public bool button = false;
	public GameObject waterInfo;
	// Use this for initialization
	void Start () {
		Debug.Log ("caozuo");
		waterInfo = GameObject.Find ("WaterInfo");
	}
	
	// Update is called once per frame
	void Update () {
        if (button)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) {
				Debug.Log ("按键1");
                renwu.restwater--;
				waterInfo.SendMessage ("TransWaterValue", renwu.restwater);
				Debug.Log ("buggggg");
                zhongzi = 1;
				GameObject.Find(renwu.tname).SendMessage("getzhongzi", zhongzi, SendMessageOptions.DontRequireReceiver);
				renwu.tname = "";
            }
			else if (Input.GetKeyDown(KeyCode.Alpha2)) {
                renwu.restwater--;
				waterInfo.SendMessage ("TransWaterValue", renwu.restwater);
                zhongzi = 2;
				GameObject.Find(renwu.tname).SendMessage("getzhongzi", zhongzi, SendMessageOptions.DontRequireReceiver);
				renwu.tname = "";
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3)) {
                renwu.restwater--;
                zhongzi = 3;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                renwu.restwater--;
                zhongzi = 4;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha5)) {
                renwu.restwater--;
                zhongzi = 5;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha6))  //使用种子后效果
            {
                GameObject.Find("renwu").SendMessage("getstatus", UI.zhuangtai,SendMessageOptions.DontRequireReceiver);
  //              SavePlants.SaveType(0);
            }
  //          GameObject.Find(renwu.tname).SendMessage("getzhongzi", zhongzi, SendMessageOptions.DontRequireReceiver);
        }
        
    }
}
