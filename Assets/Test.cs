using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {        
	private int hp = 100;
	private int power = 25;
	private int mp = 53;

	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		this.hp -= damage;
	}

	//発展課題の部分で行き詰まっています。
	public void Magic() {
		int c = this.mp - 5;
		if (c >= 5) {
				Debug.Log ("魔法攻撃をした。残りMPは" + c);
		} else {
				Debug.Log("MPが足りないため魔法が使えない。");
		}
		return c;
  }
}
	
public class Test : MonoBehaviour {

	void Start () {
		
		    Boss lastboss = new Boss ();

		    lastboss.Attack();
		    lastboss.Defence(3);
		    lastboss.Magic();
		    
		    //下記が課題です
			int [] array = {10, 25, 76, 39, 66};

			for (int i = 4; i >= 0; i--) {
				Debug.Log(array [i]);
			}

	}
	
	void Update () {
		
	}
}
