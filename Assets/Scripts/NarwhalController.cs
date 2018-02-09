using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarwhalController : MonoBehaviour {

	public Animation Narwhal;
	public Animator NarwhalAnimator;

	// Use this for initialization
	void Start () {
		NarwhalAnimator.Play("Can1Animation");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
