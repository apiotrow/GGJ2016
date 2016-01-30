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
	}
	
	void Update () {

	}
}
