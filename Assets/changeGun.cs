using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeGun : MonoBehaviour {
	public GameObject weapon1;
	public GameObject weapon2;
	/*public GameObject bulletPrefab;
	public GameObject bulletPrefab2;*/

	// Use this for initialization
	void Start () {
		weapon1.SetActive(true);
		weapon2.SetActive(false);
		/*bulletPrefab.SetActive(true);
		bulletPrefab2.SetActive(false);*/

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("1"))
		{
			weapon1.SetActive(true);
			weapon2.SetActive(false);
			/*bulletPrefab.SetActive(true);
			bulletPrefab2.SetActive(false);*/
		}
		if (Input.GetKeyDown("2"))
		{
			weapon1.SetActive(false);
			weapon2.SetActive(true);
			/*bulletPrefab.SetActive(false);
			bulletPrefab2.SetActive(true);*/
		}

	}
}
