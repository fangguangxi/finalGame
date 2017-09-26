using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCLoseby : MonoBehaviour {

    public GotKey playerGetKey;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, gameObject.transform.position) < 1f)
        {
            playerGetKey.KeyGot();
        }
    }
}