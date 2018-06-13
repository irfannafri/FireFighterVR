using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timerTwo : MonoBehaviour {
	Image fillImg;
	float timeAmt =60;
	float time;
	public Text timeText;  

	// Use this for initialization
	void Start () {
		fillImg = this.GetComponent<Image>();
		time = timeAmt;
	}

	// Update is called once per frame
	void Update () {
		if(time  > 0){
			time -= Time.deltaTime;
			fillImg.fillAmount = time / timeAmt; 
			timeText.text = "Waktu:\n "+time.ToString("F");  
		}
		if (time <= 0) {
			int menu = 0;
			timeText.text = "Waktu habis ";
			Application.LoadLevel(menu);
		}
	}
}