using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class enemyFollowing : MonoBehaviour {
	public Transform player;


	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame

	void Update () {
		
		transform.LookAt (player);
		transform.Translate (Vector3.forward * 3 * Time.deltaTime);
	}
}

