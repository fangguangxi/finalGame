using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class takeDamage : MonoBehaviour {
	GameObject enemy;
	// Use this for initialization
	void Start () {
		
	}
	public int enemy_Life = 50;
	public Text txt;
	// Update is called once per frame
	void Update () {
		txt.text = "Enemy Life:" + " " + enemy_Life;
		if (enemy_Life == 0) {
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		TakeDamage ();
	}

	public void TakeDamage(){
		enemy_Life = enemy_Life - 10;


	}
}
