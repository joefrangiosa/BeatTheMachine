using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed;
    public float maxDistance;
    public float bulletDmg;

    private GameObject targetEnemy;

	void Update ()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        maxDistance += 1 * Time.deltaTime;
        
        if(maxDistance >= 5)
        {
            Destroy(this.gameObject);
        }	
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Node")
        {
            targetEnemy = other.gameObject;
            targetEnemy.GetComponent<Node>().health -= bulletDmg;
            Destroy(this.gameObject);
        }
    }
}
