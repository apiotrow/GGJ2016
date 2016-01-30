﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class SceneThing : MonoBehaviour {
	Animator anim;
	Button btnA;

	public string currScene;

	public class SceneSomething{
		public string BGmusic;
		public string background;

	}

	void Start () {
		anim = GetComponent<Animator>(); 
		btnA = GameObject.Find("BtnA").GetComponent<Button>();

		SceneSomething scene1 = new SceneSomething();
		scene1.background = "sdfsfg";
		scene1.BGmusic = "sdfsfg";

		//button listener
		btnA.onClick.AddListener (() => {
			anim.SetTrigger("A");
		});
		 

	}
	

	void Update () {


	}
}
