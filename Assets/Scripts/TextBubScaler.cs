using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextBubScaler : MonoBehaviour {
	public RectTransform bubText;

	void Start () {
		bubText = transform.parent.transform.Find("TalkBubText").gameObject.GetComponent<RectTransform>();
	}
	
	void Update () {
		GetComponent<RectTransform>().sizeDelta = 
			new Vector2(
				GetComponent<RectTransform>().sizeDelta.x, 
				bubText.sizeDelta.y * 1.1f
			);


//		bubText.anchoredPosition = new Vector2(GetComponent<RectTransform>().anchoredPosition.x, GetComponent<RectTransform>().anchoredPosition.y); 
	
	}
}
