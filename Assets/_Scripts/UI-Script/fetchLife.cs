﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fetchLife : MonoBehaviour {
	private Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		// replace this coming int
		int coming_int = 1;
		string score = coming_int.ToString ("D2");
		text.text = score;
	}
}