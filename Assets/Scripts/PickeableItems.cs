using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickeableItems : MonoBehaviour
{
    public Weapons weapon;
    public Armors armor;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player" && this.gameObject.tag == "Weapon") 
        {
            Inventory.Instance.AddWeapon(weapon);
            Destroy(gameObject);

        }else if(other.gameObject.tag == "Player" && this.gameObject.tag == "Armor")
        {
            Inventory.Instance.AddArmor(armor);
            Destroy(gameObject);

        }
    }
}
