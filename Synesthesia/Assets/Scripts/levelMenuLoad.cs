using UnityEngine;
using System.Collections;

public class levelMenuLoad : MonoBehaviour {
	public GameObject level2Icon;
	// Use this for initialization
	void Start () {
		//Might be null???
		if (PlayerPrefs.GetString ("level1").Equals ("true")) {
			level2Icon.SetActive (true);


		}
	}
}
