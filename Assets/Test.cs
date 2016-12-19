﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {        
	public int hp = 100;
	private int power = 25;
	private int mp = 53;

	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		this.hp -= damage;
	}
	public void Magic() {
		if (mp >= 5) {
			    this.mp -= 5;
				Debug.Log ("魔法攻撃をした。残りMPは" + mp);
		} else {
				Debug.Log("MPが足りないため魔法が使えない。");
		}
}
}
	
public class Test : MonoBehaviour {

	void Start () {
		
		    Boss lastboss = new Boss ();

		    lastboss.Attack();
		    lastboss.Defence(3);
		    //for文、１１回まわすと良い
		    for (int i = 0; i<=10; i++) {
		        lastboss.Magic();
		    }

			int [] array = {10, 25, 76, 39, 66};
		    for (int i = 0; i < array.Length; i++) {
			    Debug.Log(array [i]);
		    }
			for (int i = 4; i >= 0; i--) {
				Debug.Log(array [i]);
			}

	}
	
	void Update () {
	
	}

}
