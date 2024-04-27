using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicdicontrol : MonoBehaviour
{
    public GameObject[] pencetan;
    public AudioSource suara;
    public int click = 0;
    // Use this for initialization
    void Start()
    {

        if (PlayerPrefs.GetInt("suara") == 0 && PlayerPrefs.GetInt("musik") == 0)
        {
            click = 0;
            aktif(0);
            suara.Pause();
            PlayerPrefs.SetInt("musik", 1);
        }
        else if (PlayerPrefs.GetInt("suara") == 1 && PlayerPrefs.GetInt("musik") == 0)
        {
            click = 1;
            aktif(1);
            suara.Play();
            PlayerPrefs.SetInt("musik", 1);
        }

        if (PlayerPrefs.GetInt("suara") == 0)
        {
            click = 0;
            aktif(0);
        }
        else if (PlayerPrefs.GetInt("suara") == 1)
        {
            click = 1;
            aktif(1);
        }
    }

    void OnMouseDown()
    {
        click++;
    }

    void OnMouseUp()
    {
        if (click % 2 == 0)
        {
            PlayerPrefs.SetInt("suara", 0);
            aktif(0);
        }
        else
        {
            PlayerPrefs.SetInt("suara", 1);
            aktif(1);
        }
    }

    void aktif(int objek)
    {
        for (int i = 0; i < pencetan.Length; i++)
        {
            pencetan[i].SetActive(false);
        }
        pencetan[objek].SetActive(true);
    }
}
