using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayersLife : MonoBehaviour {
	GameObject player;
	// Use this for initialization
	void Start () {

	}
	public int player_Life = 1030;
	public Text txt;
	// Update is called once per frame
	void Update () {
		txt.text = "Player Life:" + " " + player_Life;
		if (player_Life == 0) {
			SceneManager.LoadScene("scene1", LoadSceneMode.Single);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		TakeDamage ();
	}

	public void TakeDamage(){
		player_Life = player_Life - 10;


	}
}
