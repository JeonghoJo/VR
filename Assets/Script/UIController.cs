using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
    public Image itemImageIteamWindow;
    public Text itemTextIteamWindow;
    public GameObject weaponPosition;

    Ray ray;
    RaycastHit hitInfo;
    Vector3 originVextor3 = new Vector3(0, 0, 0);
    Quaternion originQuaternion;

    private void Start()
    {
        originQuaternion.eulerAngles = originVextor3;
    }

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        hitInfo = new RaycastHit();
        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.collider.gameObject.layer == 10 && Input.GetButtonDown("Fire1"))
            {
                ItemClick();
            }
        };
    }

    void ItemClick()
    {
        if (hitInfo.collider.gameObject.GetComponent<IteamInfo>())
        {
            itemImageIteamWindow.sprite =  hitInfo.collider.gameObject.GetComponent<IteamInfo>().itemImage;
        }

        itemTextIteamWindow.text = hitInfo.collider.gameObject.name;

    }
}