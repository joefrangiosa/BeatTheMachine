using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    [Header("Main Player Stats")]
    public string playerName;
    public int skillPoints = 0;                     //0 + 1 per level complete;
    public float playerHealth = 200;                //200 + 10 per level complete; 
    public float playerHealthRegen = 0.3f;          //0.3f + 0.0 per level complete;
    public float playerDamage = 20.0f;              //20 + 1.3 per level complete;
    public float playerMovement = 5.0f;             //5.0 + 0.25 per level complete;
    public float playerAttackSpeed = 0.875f;        //0.875 + 2.5% per level complete;

    public float timer = 0;

    [Header("Player Attributes")]
    public List<PublicMethods> Attributes = new List<PublicMethods>();


    void Start ()
    {
		
	}

    void Update()
    {
        SetStatUpdate();
    }

    void SetStatUpdate()
    {
        if (playerHealth <= 200)
        {
            playerHealth += playerHealthRegen * Time.deltaTime;
        }
        else
        {
            
        }
    }
}
