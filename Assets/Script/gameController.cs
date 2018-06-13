using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class gameController : MonoBehaviour {
    public string objek;
    public TextMesh infoText;
    public static RaycastHit hit;

	// Use this for initialization
	public void changemenuscene(string namascene){
		infoText.text = "MISSION SUCCESS";
		Application.LoadLevel(namascene);
	}
	// Update is called once per frame
	void Update () {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.transform.tag == "gas")
            {
                infoText.text = "tulisan\n";
            }
        }
    }

    public void gazeOnObjek()
    {
        infoText.text = objek + "\n";
    }
    public void gazeOffObjek()
    {
        infoText.text = "\n";
    }
	public void gazeOffObjek2()
	{
		infoText.text = "\n";
	}
    public void clickOnObjek()
    {
        Destroy(gameObject);
        infoText.text = "\n";
    }
	public void clickOnObjek2()
	{
		Destroy(gameObject);
		infoText.text = "kain berhasil diambil";
	}
}
