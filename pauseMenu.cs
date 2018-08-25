
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;

	public GameObject pausedMenu;
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Cursor.lockState = CursorLockMode.Confined;
			Cursor.visible = true;
			if (GameIsPaused) {
				Resume ();
			} 
			else {
				Pause ();
			}
		}
	}

	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		Time.timeScale = 1f;
	}
	public void Resume(){
		pausedMenu.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}
	public void Menu(){
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Menu");
	}
	public void Pause(){
		pausedMenu.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}
}
