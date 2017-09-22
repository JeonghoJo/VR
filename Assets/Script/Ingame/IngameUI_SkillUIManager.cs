using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameUI_SkillUIManager : MonoBehaviour {

    public GameObject[] firstTierSkillUIList;
    
    public const int defaultSelectedSkill = 1;

    private int nowSelectedSkill;    
    private void Awake()
    {        
        if (defaultSelectedSkill > firstTierSkillUIList.Length)            
            Debug.LogError("now default Selected Skill in UI : " + defaultSelectedSkill 
                + " Length : " + firstTierSkillUIList.Length);      
        nowSelectedSkill = defaultSelectedSkill;
        SelectSkill(nowSelectedSkill);
    }
    // Update is called once per frame
    void Update () {
        SkillInputManager();
		
	}
    public void SelectSkill(int Skill)
    {
        if (Skill < firstTierSkillUIList.Length)
        {
            for (int i = 0; i < firstTierSkillUIList.Length; i++)
                firstTierSkillUIList[i].GetComponent<IngameUI_SelectedSkill>().SelectButton(false);
            firstTierSkillUIList[Skill].GetComponent<IngameUI_SelectedSkill>().SelectButton(true);
            nowSelectedSkill = Skill;
        }
        else
            Debug.Log("Wrong Skill Number");
    }
    private void SkillInputManager()
    {
        if(Input.GetButtonUp("Fire2"))// Have to set for Vive Controller
        {
            nowSelectedSkill++;
            nowSelectedSkill = nowSelectedSkill % firstTierSkillUIList.Length;
            SelectSkill(nowSelectedSkill);            
        }
    }    
}
