using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScreenUIManager : MonoBehaviour {
	public SceneManager sceneManag;

	public Button actionBtn1;
	public Button actionBtn2;
	public Button actionBtn3;

	void Start () {

		actionBtn1.onClick.AddListener (() => {
			print("action 1");
			sceneManag.makeItRain();
		});

		actionBtn2.onClick.AddListener (() => {
			print("action 2");
		});

		actionBtn3.onClick.AddListener (() => {
			print("action 3");
		});


		actionBtn1.gameObject.SetActive(false);
		actionBtn2.gameObject.SetActive(false);
		actionBtn3.gameObject.SetActive(false);
	}
	
	void Update () {
		
	}

	public void revealButtons(){
		actionBtn1.gameObject.SetActive(true);
		actionBtn2.gameObject.SetActive(true);
		actionBtn3.gameObject.SetActive(true);
	}
}
