using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PublicMethods : MonoBehaviour {

    public Attributes attribute;
    public int amount;

    public PublicMethods(Attributes attribute, int amount)
    {
        this.attribute = attribute;
        this.amount = amount;
    }
}
