using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {
	public Image[] life ;
	int count = 0;
	// Update is called once per frame
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag != "rings" && col.gameObject.tag != "gameFinish") {
			Destroy (life [count]);
			count++;
		}
		if (count >= 3) {
			SceneManager.LoadScene ("Menu");
			Cursor.lockState = CursorLockMode.Confined;
			Cursor.visible = true;
		}
	}
}
