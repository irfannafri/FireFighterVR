using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer2 : MonoBehaviour {
	public string levelToLoad;
	public int timeLeft = 60;
	public Text countdownText;

	// Use this for initialization
	void Start () {
		StartCoroutine ("LoseTime");
	}

	// Update is called once per frame
	void Update () {
		countdownText.text = ("Sisa Waktu " + timeLeft);

		if (timeLeft <= 0) {
			StopCoroutine ("LoseTime");
			SceneManager.LoadScene(1);
		}
	}

	IEnumerator LoseTime(){
		while (true) {
			yield return new WaitForSeconds (1);
			timeLeft--;
		}
	}
}