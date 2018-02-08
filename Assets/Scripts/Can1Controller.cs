using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can1Controller : MonoBehaviour {

	public Animation Can1;
	public Animator Can1Animator;

	// Use this for initialization
	void Start () {
		Debug.Log ("We are in start!");
		Can1Animator.Play("Can1Animation");
		Can1.clip.isLooping = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
