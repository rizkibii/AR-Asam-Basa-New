using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lanjut : MonoBehaviour
{
    public string NamaScene;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnMouseUp()
    {
        SceneManager.LoadScene(NamaScene);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
