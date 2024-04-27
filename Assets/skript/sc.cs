using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    public GameObject Object;

    private bool _ZoomIn;
    private bool _ZoomOut;

    //object scale speed
    public float Scale = 0.001f;
    public float maxScale, minScale ;

    // Update is called once per frame
    void Update()
    {
        if (_ZoomIn)
        {
            //make a bigger object
            if (Object.transform.localScale.x <= maxScale)
            {
                Object.transform.localScale += new Vector3(Scale, Scale, Scale);
            } else
            {
                Object.transform.localScale += new Vector3(0f, 0f, 0f);
            }
        }

        if (_ZoomOut)
        {
            //make a small object
            if (Object.transform.localScale.x >= minScale)
            {
                Object.transform.localScale -= new Vector3(Scale, Scale, Scale);
            }
            else
            {
                Object.transform.localScale -= new Vector3(0f, 0f, 0f);
            }
        }
    }

    //Make object scaled big
    public void OnPressZoomIn()
    {
        
            _ZoomIn = true;

        
        
    }

    public void OnReleaseZoomIn()
    {
        
            _ZoomIn = false;
        
    }

    //Make object scaled small
    public void OnPressZoomOut()
    {
        
            _ZoomOut = true;
        
            
    }

    public void OnReleaseZoomOut()
    {
        _ZoomOut = false;
    }
}
