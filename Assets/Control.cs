using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {
	
	public float number{
		get{
			return _number * 10;
		}
		set{
			_number = value * 2;
		}
	}	
	private float _number = 0.1f;
}
