using UnityEngine.UI;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Time_Remaining : MonoBehaviour {
	public Text timeRemaining;
	private int startTime=60;
	void Start(){
		StartCoroutine ("loseTime");
	}
	void Update () {
		timeRemaining.text = ("Time Remaining\n" + startTime.ToString());
		if (startTime <= 0) {
			StopCoroutine ("loseTime");
			timeRemaining.text = ("Time Up");
			Restart ();
		}
	}
	public void Restart(){
		//WaitForSeconds (5);
		StartCoroutine ("waiting");
		SceneManager.LoadScene ("end");
	}
	IEnumerator loseTime(){
		while(true){
			yield return new WaitForSeconds (1);
			startTime--;
		}
	}
	IEnumerator waiting(){
		yield return new WaitForSeconds (5f);
	}
	void OnCollisionEnter(Collision col){
		if(col.gameObject.name=="LP"){
			Debug.Log (startTime);
			startTime = startTime + 10;
			Debug.Log (startTime);
			Update ();
		}
	}
}