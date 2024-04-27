using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
       // PlayerPrefs.SetInt("suara", 1);
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length >= 2) { 
            Destroy(this.gameObject);
        } else { DontDestroyOnLoad(this.gameObject); }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerPrefs.GetInt("suara") == 1)
        {
            GetComponent<AudioSource>().volume = 0.5f;
        }
        else
        {
            GetComponent<AudioSource>().volume = 0;
        }
        //DontDestroyOnLoad(this.gameObject);
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("suara", 1);
        PlayerPrefs.SetInt("musik", 1);
    }

}
