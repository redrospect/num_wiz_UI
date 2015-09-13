using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {  //needs to be public. the string allows for input in unity-tells what scene to load
		Debug.Log ("Level load requested for:" +name);
		Application.LoadLevel(name);

	}

	public void QuitRequest() {
		Debug.Log ("Level quit requested");
		Application.Quit ();
	}

	public void Back(string name) {
		Debug.Log ("Back requested");
		Application.LoadLevel(name);
	}



}
