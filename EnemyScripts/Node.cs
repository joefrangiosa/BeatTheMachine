using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour {

    public float health;
    public float maximumHealth = 25;

    [SerializeField]
    RectTransform healthBar;

    Bullet BulletScript;
    public float bulletDmg;

    GameObject detectedHit;

    void Start()
    {
        BulletScript = GetComponent<Bullet>();
    }

    void Update()
    {
        SetHealthBar(health);
        if (health <= 0)
        {
            Die();
        }
    }

    void SetHealthBar (float health)
    {
        health = health / maximumHealth;
        healthBar.localScale = new Vector3(health, 1, 1);
    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            detectedHit = other.gameObject;
            detectedHit.GetComponent<Player>().health -= maximumHealth;
            Destroy(this.gameObject);
        }
    }

}
