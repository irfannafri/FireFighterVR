using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastThing : MonoBehaviour {

    public Canvas myCanvas;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Jump"))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100.0f))
            {
                if (hit.transform.tag == "gas")
                {
					Debug.Log (hit.transform.tag);
                    if (myCanvas.enabled == false) myCanvas.enabled = true;
                    else myCanvas.enabled = false;
                }
            }
        }
    }
}
