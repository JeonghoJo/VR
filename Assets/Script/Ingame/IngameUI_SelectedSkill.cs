using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameUI_SelectedSkill : MonoBehaviour {

    public GameObject[] nextTierSkillList;

    public static float selectedImageSize;
    public static float nonSelectedImageSize = 0.25f;
    public float zoomSpeed = 0.01f;

    public GameObject skillImage;


    private bool isSelected = false;
    private RectTransform rt;

    private void Awake()
    {
        rt = skillImage.GetComponent<RectTransform>();
        selectedImageSize = rt.sizeDelta.x;
        
    }

    // Update is called once per frame
    void Update () {
        if(isSelected)
        {
            ZoomInImageSize();
        }
        else
        {
            ZoomOutImageSize();
        }
		
	}
    void ZoomInImageSize()
    {
        if (rt.sizeDelta.x < selectedImageSize)
        {
            float sizeValue = rt.sizeDelta.x + (zoomSpeed * Time.deltaTime);
            Vector2 plusSizeDelta = new Vector2(sizeValue, sizeValue);
            rt.sizeDelta = plusSizeDelta;
        }
    }
    void ZoomOutImageSize()
    {
        if(rt.sizeDelta.x > nonSelectedImageSize)
        {
            float sizeValue = rt.sizeDelta.x - (zoomSpeed * Time.deltaTime);
            Vector2 minusSizeDelta = new Vector2(sizeValue, sizeValue);
            rt.sizeDelta = minusSizeDelta;
        }
    }
    public void SelectButton(bool value)
    {
        isSelected = value;        
    }
    
}
