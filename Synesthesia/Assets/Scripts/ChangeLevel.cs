using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour {

	public void selectLevel(int level){
		SceneManager.LoadScene (level, LoadSceneMode.Single);
	}
}
