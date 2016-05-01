using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelFive : MonoBehaviour {
	public GameObject endImageWin;
	public GameObject endImageLose;
	public string[] melody;
	public string[] userInput;
	public bool audioPlaying;
	public AudioSource c;
	public AudioSource e;
	public AudioSource g;
	public AudioSource b;
	public AudioSource d;
	public int numClicked;
	public bool iswinning;

	// Use this for initialization
	IEnumerator Start () {
		melody = new string[7];
		melody [0] = "c";
		melody [1] = "e";
		melody [2] = "g";
		melody [3] = "b";
		melody [4] = "b";
		melody [5] = "c";
		melody [6] = "c";
		userInput = new string[7];
		audioPlaying = true;
		c.Play ();
		yield return new WaitForSeconds (1);
		e.Play ();
		yield return new WaitForSeconds (1);
		g.Play ();
		yield return new WaitForSeconds (1);
		e.Play ();
		yield return new WaitForSeconds (1);
		c.Play ();
		yield return new WaitForSeconds (1);
		c.Play ();
		yield return new WaitForSeconds (1);
		c.Play ();
		yield return new WaitForSeconds (1);
		numClicked = 0;
		audioPlaying = false;
	}

	public void click(string note){
		if (!audioPlaying) {
			if (note.Equals ("e")) {
				e.Play ();
			} else if (note.Equals ("c")) {
				c.Play ();
			} else if (note.Equals ("g")) {
				g.Play ();
			} else if (note.Equals ("b")) {
				b.Play ();
			}
			userInput [numClicked] = note;
			numClicked++;
			if (numClicked == 7) {
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
		for (int i = 0; i < 7; i++) {
			if (!userInput [i].Equals (melody [i])) {
				iswinning = false;
			}
		}
		if (iswinning) {
			endImageWin.SetActive (true);
			PlayerPrefs.SetString ("level4", "true");
		} else {
			endImageLose.SetActive (true);
			if (!PlayerPrefs.GetString ("level4").Equals ("true")) {
				PlayerPrefs.SetString ("level4", "false");
			}
		}
	}
}
