using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTriggerscene3 : MonoBehaviour {

	public GotKey player;
	public openScene3door pikadoor;

	// Use this for initialization
	void Start()
	{

	}
	// Update is called once per frame
	void Update()
	{

		bool playerHasKey = player.hasGoldKey;

		if (Vector3.Distance(
			gameObject.transform.position,
			player.transform.position) < 3f && playerHasKey)
		{
			pikadoor.moveDown();

		}
	}
}
