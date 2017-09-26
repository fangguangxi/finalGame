using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	public int playersLife = 500;
	public Text txt;
	void Update () {
		txt.text = "Players Life：" + " " + playersLife;
		if (playersLife == 0) {
			SceneManager.LoadScene("scene1", LoadSceneMode.Single);
		}
	}
	public void TakeDamage()
	{		
		playersLife = playersLife - 100;
	}

	public void HealDamage()
	{

		playersLife = playersLife + 100;

	}
}
