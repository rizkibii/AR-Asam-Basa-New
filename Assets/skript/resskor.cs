using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resskor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("salah", 0);
        PlayerPrefs.SetInt("benar", 0);
        PlayerPrefs.SetInt("skor", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
