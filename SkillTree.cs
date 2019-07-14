using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTree : MonoBehaviour {

    public static float playerHealth;
    public static float playerArmor;
    public Button skillNode1;
    public Button skillNode2;
    public Button skillNode3;
    public Button skillNode4;
    public static int totalSkillPoints = 0;


    void Start ()
    {
		
	}
	
	void Update ()
    {
		if (totalSkillPoints == 0)
        {
            skillNode1.GetComponent<Button>().enabled = false;
        }
        else
        {
            skillNode1.GetComponent<Button>().enabled = true;
        }
	}
}
