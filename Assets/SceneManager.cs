using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
	public Animator sceneAnim;
	public ParticleSystem rain;
	public ScreenUIManager screenUI;

	void Start () {
		
	}

	void Update () {
		if(sceneAnim.GetCurrentAnimatorStateInfo(0).IsName("SceneWait"))
			screenUI.revealButtons();
	}

	public void makeItRain(){
		rain.Play();
	}

}
