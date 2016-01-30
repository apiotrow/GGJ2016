using UnityEngine;
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
		{1f, "d sgsfg seh"},
		{2f, "dsdfgaw  rr jkrkr krkr r kwk ler lekrk tk kadaf fsd fsdf sh shsrthsrtb s ag  fgbs sh h rgseg sh"},
		{3f, "gfg nfhdrt ddrtt  aeg srgh srgseg sh"},
		{4f, "d sgsfg sh"},
		{5f, "d sgdddkdm sdfosk nerkgjnsrthos kefngaelrg srtlst jnbsrtrgseg sh"},
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
		anim = GetComponent<Animator>();
		animstate = 1f;
	}
	

	void Update () {


		print(animstate);
		//if animation triggered is already playing, don't play it
		if(animstate != 0f && !anim.GetCurrentAnimatorStateInfo(0).IsName(animDic[animstate]))
			anim.SetTrigger(animDic[animstate]);

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
