using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnMouseUp()
	{
		Application.Quit ();
        PlayerPrefs.SetInt("musikapik", 1);
        PlayerPrefs.SetInt("suaraapik", 1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
