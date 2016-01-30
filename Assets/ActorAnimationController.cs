using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActorAnimationController : MonoBehaviour {
	Animator anim;

	public float animstate;

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

		if(!anim.GetCurrentAnimatorStateInfo(0).IsName(animDic[animstate]))
			anim.SetTrigger(animDic[animstate]);
		
	}

}
