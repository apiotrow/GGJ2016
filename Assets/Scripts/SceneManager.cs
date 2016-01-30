using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SceneManager : MonoBehaviour {
	public Animator sceneAnim;
	public ParticleSystem rain;

	public Button actionBtn1;
	public Button actionBtn2;
	public Button actionBtn3;

	void Start () {
		actionBtn1.onClick.AddListener (() => {
			//			sceneManag.makeItRain();
			sceneAnim.SetTrigger("A");
		});

		actionBtn2.onClick.AddListener (() => {
			sceneAnim.SetTrigger("B");
		});

		actionBtn3.onClick.AddListener (() => {
			sceneAnim.SetTrigger("C");
		});

		hideButtons();
	}

	void Update () {
		if(sceneAnim.GetCurrentAnimatorStateInfo(0).IsName("SceneWait")){
			revealButtons();
		}else{
			hideButtons();
		}
	}

	public void makeItRain(){
		rain.Play();
	}

	public void hideButtons(){
		actionBtn1.gameObject.SetActive(false);
		actionBtn2.gameObject.SetActive(false);
		actionBtn3.gameObject.SetActive(false);
	}

	public void revealButtons(){
		actionBtn1.gameObject.SetActive(true);
		actionBtn2.gameObject.SetActive(true);
		actionBtn3.gameObject.SetActive(true);
	}
}
