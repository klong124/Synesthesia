using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelNine : MonoBehaviour {
	public GameObject endImageWin;
	public GameObject endImageLose;
	public string[] melody;
	public string[] userInput;
	public bool audioPlaying;
	public AudioSource c;
	public AudioSource e;
	public AudioSource g;
	public AudioSource b;
	public AudioSource dh;
	public int numClicked;
	public bool iswinning;

	// Use this for initialization
	IEnumerator Start () {
		melody = new string[6];
		melody [0] = "c";
		melody [1] = "c";
		melody [2] = "e";
		melody [3] = "e";
		melody [4] = "b";
		melody [5] = "dh";
		userInput = new string[14];
		audioPlaying = true;
		c.Play ();
		yield return new WaitForSeconds (1);
		c.Play ();
		yield return new WaitForSeconds (1);
		e.Play ();
		yield return new WaitForSeconds (1);
		e.Play ();
		yield return new WaitForSeconds (1);
		b.Play ();
		yield return new WaitForSeconds (1);
		dh.Play ();
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
			} else if (note.Equals ("dh")) {
				dh.Play ();
			}
			userInput [numClicked] = note;
			numClicked++;
			if (numClicked == 6) {
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
			PlayerPrefs.SetString ("level5", "true");
		} else {
			endImageLose.SetActive (true);
			if (!PlayerPrefs.GetString ("level5").Equals ("true")) {
				PlayerPrefs.SetString ("level5", "false");
			}
		}
	}
}
