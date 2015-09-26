using UnityEngine;
using System.Collections;

public class secondScreen : MonoBehaviour {

	Animator anim;
	bool enterYet=false;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Return) && !enterYet) {
			enterHit ();
		}
	}

	void enterHit () {
		enterYet=true;

		anim.SetTrigger ("EnterPressed");
	}
}
