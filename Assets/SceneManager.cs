using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
	public Animator sceneAnim;

	public ParticleSystem rain;

	bool freeze;

	void Start () {
		
	}

	void Update () {
//		if(sceneAnim.GetCurrentAnimatorStateInfo(0).IsName("SceneWait")){
//			
//		}

		if(freeze){
			pauseAnim();
		}
	}

	public void makeItRain(){
		rain.Play();
	}

	public void pauseAnim(){
		sceneAnim.speed = 0f;
	}
}
