using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class jawab : MonoBehaviour {
	//public GameObject feed_benar, feed_salah;
	// Use this for initialization
	void Start () {
		
	}
    public void OnMouseUp()
    {
        GameObject.Find("puk").GetComponent<AudioSource>().Play();
    }

    public void jawaban(bool jawab){
        GameObject.Find("puk").GetComponent<AudioSource>().Play();
        if (jawab) {
			//feed_benar.SetActive (false);
			//feed_benar.SetActive (true);
			int skor = PlayerPrefs.GetInt ("skor") + 10;
            int bener = PlayerPrefs.GetInt("bener") + 1;
			PlayerPrefs.SetInt ("skor", skor);
            PlayerPrefs.SetInt("bener", bener);
        } else {
            //feed_salah.SetActive (false);
            //feed_salah.SetActive (true);
            int salah = PlayerPrefs.GetInt("salah") + 1;
            PlayerPrefs.SetInt("salah", salah);
        }

		gameObject.SetActive (false);
		transform.parent.GetChild (gameObject.transform.GetSiblingIndex () + 1).gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
