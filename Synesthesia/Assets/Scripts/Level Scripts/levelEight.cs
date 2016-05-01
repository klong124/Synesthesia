using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelEight : MonoBehaviour {
	public GameObject endImageWin;
	public GameObject endImageLose;
	public string[] melody;
	public string[] userInput;
	public bool audioPlaying;
	public AudioSource d;
	public AudioSource b;
	public AudioSource c;
	public AudioSource e;
	public AudioSource g;
	public int numClicked;
	public bool iswinning;

	// Use this for initialization
	IEnumerator Start () {
		melody = new string[1];
		melody [0] = "d";
		userInput = new string[1];
		audioPlaying = true;
		d.Play ();
		yield return new WaitForSeconds (2);
		numClicked = 0;
		audioPlaying = false;
	}

	public void click(string note){
		if (!audioPlaying) {
			if (note.Equals ("d")) {
				d.Play ();
			} 
			else if (note.Equals ("b")) {
				b.Play ();
			} 
			else if (note.Equals ("c")) {
				c.Play ();
			} 
			else if (note.Equals ("e")) {
				e.Play ();
			} 
			else if (note.Equals ("g")) {
				g.Play ();
			} 
			userInput [numClicked] = note;
			numClicked++;
			if (numClicked == 1) {
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
			if (!userInput [0].Equals (melody [0])) {
				iswinning = false;
			}
		if (iswinning) {
			endImageWin.SetActive (true);
			PlayerPrefs.SetString ("level8", "true");
		} else {
			endImageLose.SetActive (true);
			PlayerPrefs.SetString ("level8", "false");
		}
	}
}
