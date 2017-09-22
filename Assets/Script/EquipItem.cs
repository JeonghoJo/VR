using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipItem : MonoBehaviour {

    public GameObject weaponPosition;
    public GameObject _canvasItem;
    public GameObject player;
    
    public void DoEquipItem()
    {
        if (weaponPosition.transform.GetChild(0) != null)
        {
            GameObject nowWeapon = weaponPosition.transform.GetChild(0).gameObject;
            //Debug.Log(nowWeapon.name);
            Destroy(nowWeapon);
        }
        
        player.GetComponent<PlayerInfo>().newPlayerWeapon = _canvasItem;
        Instantiate(_canvasItem, weaponPosition.transform.position, weaponPosition.transform.rotation, weaponPosition.transform);
        
    }
}
