using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pencettbl : MonoBehaviour
{
	float scaleX, scaleY;
	// Start is called before the first frame update
	public void Start()
	{
		scaleX = transform.localScale.x;
		scaleY = transform.localScale.y;
	}
	public void OnMouseDown()
	{
		GameObject.Find("puk").GetComponent<AudioSource> ().Play() ;
		transform.localScale = new Vector2(scaleX * 1.1f, scaleY / 1.1f);
	}
	public void OnMouseUp()
	{
		transform.localScale = new Vector2(scaleX, scaleY);
	}
	// Update is called once per frame
	void Update()
	{

	}
}
