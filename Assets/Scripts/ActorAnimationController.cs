﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ActorAnimationController : MonoBehaviour {
	Animator anim;
	public Text talkText;
	public Image talkBubMid;
	public Image talkBubBottom;

	public float animstate;
	public float talkState;

	public Dictionary<float, string> talkDic = new Dictionary<float, string>{
		{0f, ""},
		{1f, "...and that’s how I smote the Licorice Demons out of Helena!"},
		{2f, "I wouldn’t consider that smiting demons."},
		{3f, "Yeah, it sounds more like a beating administered under the pretense of exorcism."},
		{4f, "Hush hush. The Gods don’t exist anyway. We can do as we please."},
		{5f, "I FAILED ANOTHER KNIGHT EXAM!"},
		{6f, "Get along, little doggie."},
		{7f, "I’M NEVER GOING TO MOVE OUT OF MY PARENT’S HOVEL OR FIND A NICE LORD TO MARRY!"},
		{8f, "I reckon."},

		{9f, "Hey Bartholomew, watch this."},
		{10f, "Sir Knight, you seem troubled.  What if I told you there’s a way to banish all your woes?"},
		{11f, "What…*sniff*..way is that, good priest"},
		{12f, "Sacred secrets are yours for the low low price of 10 candy coins."},
		{13f, "Manifest Destiny."},
		{14f, "My luck is too foul to worsen."},

		{15f, "You’re trying too hard.  Just rely on the gods, and all your problems will be solved."},
		{16f, "We know what we must do, squire!"},
		{17f, "Rustle up some grub?"},
		{18f, "Wrong! We must call on the gods for aid!"},
	};

	public Dictionary<float, string> animDic = new Dictionary<float, string>{
		{1f, "IdleLeft"},
		{2f, "IdleRight"},
		{3f, "IdleFront"},
		{4f, "IdleBack"},
		{5f, "WalkLeft"},
		{6f, "WalkRight"},
		{7f, "WalkDown"},
		{8f, "WalkUp"}
	};


	void Start () {
//		anim = GetComponent<Animator>();
		animstate = 1f;
	}
	

	void Update () {


		//if animation triggered is already playing, don't play it
		//catch 0 because i'm lazy
//		if(animstate != 0f && !anim.GetCurrentAnimatorStateInfo(0).IsName(animDic[animstate]))
//			anim.SetTrigger(animDic[animstate]);

		//set talk bubbl'es text
		talkText.text = talkDic[talkState];

		//disable talk bubble BG if there's no next
		if(talkText.text == ""){
			talkBubMid.gameObject.SetActive(false);
			talkBubBottom.gameObject.SetActive(false);
		}else{
			talkBubMid.gameObject.SetActive(true);
			talkBubBottom.gameObject.SetActive(true);
		}
	}

}
