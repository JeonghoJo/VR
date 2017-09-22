using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {

    public GameObject weaponPosition;
    public GameObject playerWeapon;
    public GameObject newplayerWeapon;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayerWeaponChange()
    {
        playerWeapon = newplayerWeapon;
    }

}
