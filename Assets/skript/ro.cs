using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ro : MonoBehaviour
{
    public GameObject Object;

    private bool kanan;
    private bool kiri;
    private bool atas;
    private bool bawah;
    private bool reset;
    public float y_kanan, y_kiri, z_kanan, z_kiri, x_atas, x_bawah;

    //object scale speed
   // public float rotasi = 1f;

    // Update is called once per frame
    void Update()
    {
        if (kanan)
        {
            //make a bigger object
            Object.transform.Rotate(0f, y_kanan, z_kanan);
        }

        if (kiri)
        {
            //make a small object
            Object.transform.Rotate(0f, y_kiri, z_kiri);
        }

        if (atas)
        {
            Object.transform.Rotate(x_atas, 0f, 0f);
        }
        if (bawah)
        {
            Object.transform.Rotate(x_bawah, 0f, 0f);
        }
        
    }

    //Make object scaled big
    public void OnPressKiri()
    {
        kiri = true;
    }

    public void OnReleasekiri()
    {
        kiri = false;
    }

    //Make object scaled small
    public void OnPresskanan()
    {
        kanan = true;
    }

    public void OnReleasekanan()
    {
        kanan = false;
    }
    public void OnPressAtas()
    {
        atas = true;
    }

    public void OnReleaseAtas()
    {
        atas = false;
    }
    public void OnPressBawah()
    {
        bawah = true;
    }

    public void OnReleaseBawah()
    {
        bawah = false;
    }

}
