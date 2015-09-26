using UnityEngine;
using System.Collections;

public class genderPick : MonoBehaviour {

	float pickX, pickY;
	RectTransform[] rt; 
	// Use this for initialization
	void Start () {
	
		rt = GetComponents<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		pickX = Input.GetAxis ("Horizontal");
		pickY = Input.GetAxis ("Vertical");

		// switching option box positions
		if (pickX > 0 || pickY < 0) {
			for (int i =0; i< rt.GetLength(0); i++) {
				rt [i].anchoredPosition = new Vector2 (40, -15);
			}
		} else if (pickX < 0 || pickY > 0) {
			for (int i =0; i<rt.GetLength (0); i++){
				rt [i].anchoredPosition = new Vector2 (-40, -15);
			}
		}


	}
}
