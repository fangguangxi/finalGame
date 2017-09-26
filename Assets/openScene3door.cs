using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openScene3door : MonoBehaviour {

	public GameObject player;
	public bool opening = false;
	// Use this for initialization
	void Start()
	{

	}

	public void moveDown()
	{
		opening = true;
	}

	// Update is called once per frame
	void Update()
	{
		if (opening)
		{
			transform.Translate(0, -2 * Time.deltaTime, 0);
		}
	}
}
