using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Threading;


// Writes narrator text letter by letter
public class narratorTextManager : MonoBehaviour {

	bool written = false;
	int Delay  = 30;  // time between writing letters
	string toWrite = "Well there you are, Frank! All eager and spry in your 40-something year old youthful uhhhhh... glory. So, yeah uhh, go and explore or something.";
	Text writing;
	int currentPosition;

	void Start(){
		writing = GetComponent<Text> ();
		currentPosition = 0;

	}

	void Update(){
		if (!written) {
			if (currentPosition >= toWrite.Length){
				written = true;
			}
			writing.text = toWrite.Substring (0, currentPosition);
			Thread.Sleep (Delay);
			currentPosition++;

		}
	}
}
