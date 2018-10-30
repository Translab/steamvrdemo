using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accessor : MonoBehaviour {

	Control control;
	void Start () {
		//find control object
		control = FindObjectOfType<Control>();
		control.number = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
