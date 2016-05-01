using UnityEngine;
using System.Collections;

public class colorScript : MonoBehaviour {
	public 
	// Use this for initialization
	void Start () {
		InvokeRepeating ("colorShifter", 0.0f, 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void colorShifter(){
		Color current = new Color (Random.value, Random.value, Random.value);
		Color bgcolor = new Color (Random.value, Random.value, Random.value);
		Camera.main.backgroundColor = Color.Lerp (current, bgcolor, 5.0f);
	}
}
