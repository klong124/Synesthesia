using UnityEngine;
using System.Collections;

public class levelOne : MonoBehaviour {
	public AudioSource c;
	public GameObject endImage;
	public GameObject level2Icon;
	public bool audioPlaying;

	// Use this for initialization
	IEnumerator Start () {
		c.Play ();
		yield return new WaitForSeconds (2);
		audioPlaying = false;
	}
	public void replayMelody(){
		Start();
	}
	public void onMouseDownGreen(){
		if (!audioPlaying) {
			c.Play ();
			endImage.SetActive (true);
			PlayerPrefs.SetString ("level1", "true");
			level2Icon.SetActive (true);
		}

	}
}
