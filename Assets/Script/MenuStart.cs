using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStart : MonoBehaviour {
	public enum MenuStates
	{ Main, Level, Petunjuk, Joy};

	public MenuStates currentstate;
	public GameObject mainMenu;
	public GameObject levelMenu;
	public GameObject petunjukMenu;
	public GameObject petunjukJoy;
	// Use this for initialization
	void Start () {

	}
	public void changemenuscene(string namascene){
		Application.LoadLevel(namascene);
	}
	// Update is called once per frame
	void Update () {
		switch (currentstate) {
		case MenuStates.Main:
			mainMenu.SetActive (true);
			levelMenu.SetActive (false);
			petunjukMenu.SetActive (false);
			petunjukJoy.SetActive (false);
			break;
		case MenuStates.Level:
			mainMenu.SetActive(false);
			levelMenu.SetActive(true);
			petunjukMenu.SetActive (false);
			petunjukJoy.SetActive (false);
			break;
		case MenuStates.Petunjuk:
			mainMenu.SetActive(false);
			levelMenu.SetActive(false);
			petunjukMenu.SetActive (true);
			petunjukJoy.SetActive (false);
			break;
		case MenuStates.Joy:
			mainMenu.SetActive(false);
			levelMenu.SetActive(false);
			petunjukMenu.SetActive (false);
			petunjukJoy.SetActive (true);

			break;
		}
	}
	public void OnStartGame(){
		Debug.Log ("Masuk ke Level game!");
		currentstate = MenuStates.Level;
	}
	public void OnBantuan(){
		Debug.Log ("Masuk ke Petunjuk Game !");
		currentstate = MenuStates.Petunjuk;
	}
	public void OnBantuanJoy(){
		Debug.Log ("Masuk ke Petunjuk Joystick!");
		currentstate = MenuStates.Joy;
	}
	public void OnKembali(){
		Debug.Log ("Kembali ke main menu.");
		currentstate = MenuStates.Main;
	}

}