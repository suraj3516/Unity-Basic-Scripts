using UnityEngine.UI;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fuel : MonoBehaviour {
	private float maxFuel=3f;
	private float startFuel=3f;
	[SerializeField]
	RectTransform FuelRemaining;

	void SetFuelAmount(float _amount){
		FuelRemaining.localScale = new Vector3 (1f, _amount, 1f);
	}
	void Start(){
		StartCoroutine ("loseFuel");
	}
	void Update () {
		SetFuelAmount (startFuel);
		if (startFuel <= 0) {
			StopCoroutine ("loseFuel");
			Restart ();
		}
		if (startFuel >= maxFuel) {
			startFuel = maxFuel;
		}
	}
	public void Restart(){
		//WaitForSeconds (5f);
		StartCoroutine ("waiting");
		SceneManager.LoadScene ("end");
	}
	IEnumerator loseFuel(){
		while(true){
			yield return new WaitForSeconds (.5f);
			startFuel = startFuel - 0.04f;
		}
	}
	IEnumerator waiting(){
		yield return new WaitForSeconds (5f);
	}
	void OnCollisionEnter(Collision col){
		if(col.gameObject.name=="LP"){
			startFuel = startFuel + 1.5f;
			SetFuelAmount (startFuel);
			Destroy(col.gameObject);
		}
	}
}