using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {

    public GameObject newPlayerWeapon;
    GameObject playerWeapon;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerWeapon != newPlayerWeapon)
            playerWeapon = newPlayerWeapon;
        //Debug.Log("now weapon = "+ playerWeapon.name);
        //Debug.Log("new weapon = " + newPlayerWeapon.name);
    }

    public void PlayerWeaponChange()
    {
        playerWeapon = newPlayerWeapon;
    }

}
