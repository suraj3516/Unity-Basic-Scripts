using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	
	public Text score;
	//static variable can be accessed and modify through any class
	public static int currScore ;


	void Update(){
		score.text = ("SCORE\n" + currScore.ToString());
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "rings") {
			Destroy (col.gameObject);
			currScore += 5;
		}
	}
}
