using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelTwo1 : MonoBehaviour {
	public GameObject endImageWin;
	public GameObject endImageLose;
	public string[] melody;
	public string[] userInput;
	public bool audioPlaying;
	public AudioSource c;
	public AudioSource d;
	public int numClicked;
	public bool iswinning;

	// Use this for initialization
	IEnumerator Start () {
		melody = new string[2];
		melody [0] = "c";
		melody [1] = "d";
		userInput = new string[2];
		audioPlaying = true;
		c.Play ();
		yield return new WaitForSeconds (2);
		d.Play ();
		yield return new WaitForSeconds (2);
		numClicked = 0;
		audioPlaying = false;
	}
	
	public void click(string note){
		if (!audioPlaying) {
			if (note.Equals ("d")) {
				d.Play ();
			} else if (note.Equals ("c")) {
				c.Play ();
			}
			userInput [numClicked] = note;
			numClicked++;
			if (numClicked == 2) {
				didWin ();
			}
		}

	}

	public void replayMelody(){
		Start();
	}

	public void tryAgain(){
		int scene = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (scene, LoadSceneMode.Single);
	}

	public void didWin(){
		for (int i = 0; i < 2; i++) {
			if (!userInput [i].Equals (melody [i])) {
				iswinning = false;
			}
		}
		if (iswinning) {
			endImageWin.SetActive (true);
			PlayerPrefs.SetString ("level2", "true");
		} else {
			endImageLose.SetActive (true);
			PlayerPrefs.SetString ("level2", "false");
		}
	}
}
