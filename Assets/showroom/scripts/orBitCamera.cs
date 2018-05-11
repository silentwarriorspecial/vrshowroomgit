using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orBitCamera : MonoBehaviour {
	public float offset=10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = Camera.main.transform.position + Camera.main.transform.forward * offset;
	}
}
