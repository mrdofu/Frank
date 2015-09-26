using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// player controlled movement
	float moveX, moveY;
	SpriteRenderer sprit;
	int walkCounter=0, animateCount=20;
	 
	// Use this for initialization
	void Start () {
		// identifies the sprite renderer to pass different sprites
		sprit  = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		moveX = Input.GetAxis ("Horizontal");
		moveY = Input.GetAxis ("Vertical");

		// restricting movement to one direction
		if (moveX != 0) {
					moveY = 0;	
				} else if (moveY != 0) {
					moveX = 0;
				}

		// displays different sprites based on location
		// right
		if (moveX > 0) {
			sprit.sprite = (Sprite) Resources.Load("frankright", typeof(Sprite));	
		} 
		// left
		else if (moveX < 0) {
			sprit.sprite = (Sprite) Resources.Load("frankleft", typeof(Sprite));	
		} 
		// up
		else if (moveY > 0) {
			// animated walking
			if (walkCounter < animateCount) {
				sprit.sprite = (Sprite) Resources.Load ("frankback1", typeof(Sprite));	
			} 
			else {
				sprit.sprite = (Sprite) Resources.Load ("frankback2", typeof(Sprite));
				if (walkCounter >= 2 * animateCount)
					walkCounter = 0;
			}
			walkCounter++;
		} 
		// down
		else if (moveY < 0) {
			// animated walking
			if (walkCounter < animateCount) {
				sprit.sprite = (Sprite)Resources.Load ("frankfront1", typeof(Sprite));	
			}
			else {
				sprit.sprite = (Sprite) Resources.Load ("frankfront2", typeof(Sprite));
				if (walkCounter >= 2 * animateCount)
					walkCounter = 0;
			}
			walkCounter++;
		}

		rigidbody2D.velocity = new Vector2 (moveX, moveY);


	}


}
