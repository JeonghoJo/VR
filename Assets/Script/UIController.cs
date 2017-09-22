using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public Image itemImageIteamWindow;
    public Text itemTextIteamWindow;
    public GameObject weaponPosition;
    public GameObject minion = null;
    GameObject minionOnRay = null;
    bool minionIsPick = false;
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
            if (hitInfo.collider.gameObject.layer == 10 && Input.GetButtonDown("Fire1")) // layer 10 = Item
            {
                ItemClick();
            }
            if (hitInfo.collider.gameObject.layer == 11 && Input.GetButtonDown("Fire1")) // layer 11 = minion
            {
                if (minionIsPick == false)
                    MinionClick();
            }
            if (minionIsPick)
            {
                minionOnRay.transform.position = hitInfo.point;
                if (hitInfo.collider.gameObject.layer == 12 && Input.GetButtonDown("Fire1")) // layer 12 = Table
                {
                    minion.GetComponent<MinionInfo>().minionStack--;
                    minionOnRay.layer = 13; // layer 13 = Minion On Table
                    minionOnRay = null;
                    minion = null;
                    minionIsPick = false;
                }
            }
            Debug.Log(hitInfo.collider.gameObject.layer);
        }
    }

    void ItemClick()
    {
        if (hitInfo.collider.gameObject.GetComponent<IteamInfo>())
        {
            itemImageIteamWindow.sprite =  hitInfo.collider.gameObject.GetComponent<IteamInfo>().itemImage;
        }

        itemTextIteamWindow.text = hitInfo.collider.gameObject.name;

        gameObject.GetComponent<EquipItem>()._canvasItem = hitInfo.collider.gameObject;
        //Debug.Log(canvasItem.name);
    }

    void MinionClick()
    {
        if (hitInfo.collider.gameObject.GetComponent<MinionInfo>().minionStack > 0)
        {
            minionIsPick = true;
            minion = hitInfo.collider.gameObject;

            minionOnRay = Instantiate(minion);
            minionOnRay.layer = 2; // layer 2 = Ignore Raycast

        }
    }
}