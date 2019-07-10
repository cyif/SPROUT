using UnityEngine;
using System.Collections;
using ZJUGame;

[RequireComponent(typeof(Rigidbody2D))]
public class renwu : MonoBehaviour {
    public int rstatus = 0;  //种子在人身上体现的状态
    float waili = 0;      //提供的外力
    bool whtherp = false; //是否攀爬
    public Vector3 sudu= new Vector3(0,3,0);  //弹簧给的速度
    static public int restwater = 10;   //剩余水量
    static public float usetime = 0;  //所花时间
    static public string tname;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="other"></param>
    void OnCollisionEnter2D(Collision2D other)   
    {
		Debug.Log ("Collision!!!");
		Debug.Log ("\tzhongzi: " + caozuo.zhongzi);
		Debug.Log ("\ttag: " + other.transform.tag);
		if (other.transform.tag == "tukeng") {
			Debug.Log ("Collision: tukeng");
			tname = other.transform.name;//土坑的话按钮可用
			caozuo.button = true;
		} else if (other.transform.tag == "special" && caozuo.zhongzi != 1) {
			Debug.Log ("Collision: special");
			tname = other.transform.name;//有些地形藤蔓长不出来
			caozuo.button = true;
		} else if (other.transform.name == "tongguan") {  //通关到结算场景
			Debug.Log ("过关");
			if (Guoguan.guanshu >= SelectLevel.unlocked) {//当前关卡比总关卡大于或等于
				SelectLevel.unlocked += 1;
				Debug.Log ("hhhhhhh");
			}
			Debug.Log (SelectLevel.unlocked);
			Debug.Log (Guoguan.guanshu);
			Application.LoadLevel ("03-victory");
		} else if (other.transform.name == "jiguananniu")   //控制机关消失
            GameObject.Destroy (GameObject.Find ("jiguan"));
		else if (other.transform.name == "ci")  //碰刺死亡
            Application.LoadLevel ("dead");
		else if (other.transform.tag == "tantiao") {
			//other.transform.GetComponent<Animation> ().Play ("Take 001");
			Debug.Log("弹跳!");
			GetComponent<Player> ().usingTanhuang = 1;
			GetComponent<PlayerJump> ().holdToJumpHigher.initialJump = 12;
		}
        
    }

    void getstatus(int status)  //得到使用种子后的信息
    {
        rstatus = status;        
    }

    void OnTriggerStay2D(Collider2D other) 
    {
		if (other.name == "feng" && rstatus == 3)  //风中得到外力
            waili = 13;
		else if (other.name == "yandi" && rstatus != 5)  //炎地中无冰状态死亡
            Application.LoadLevel ("dead");
		else if (other.name == "tengwan")  //可以爬
            this.whtherp = true;
		else if (other.name == "message1") { //消息不可见
//			Debug.Log (GameObject.Find ("Teach01"));
//			GameObject.Find("Teach01").SendMessage ("SetVisible", false, SendMessageOptions.DontRequireReceiver);
//			SetTeach01.SetVisible(true);
		}
  //      else if (other.name == "message2")  //消息不可见
	//		teach02.SetVisible(false);
//            GameObject.Find("Teach02").SendMessage("SetVisible", false, SendMessageOptions.DontRequireReceiver);

    }
    void OnTriggerEnter2D(Collider2D other)
    {
//		SetTeach01 teach01 = GetComponent<SetTeach01> ();
//		SetTeach02 teach02 = GetComponent<SetTeach02> ();

		if (other.name == "message1") {  //消息不可见 
			Debug.Log("Enter Message");
			SetTeach01.SetVisible (true);
//			teach01.SetVisible (true);
//			SetTeach01.flag = true;
		}
		else if (other.name == "message2")// { //消息不可见		
			SetTeach02.SetVisible(true);
//		}
		else if(other.name == "water")
        {
            restwater++;
            GameObject.Destroy(other);
        }
    }
        void OnTriggerExit2D(Collider2D other)
    {
        caozuo.button = false;
        whtherp = false;
        waili = 0;
		if(other.name =="message1")
			SetTeach01.SetVisible(false);
		else if(other.name == "message2")
			SetTeach02.SetVisible(false);
        
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
