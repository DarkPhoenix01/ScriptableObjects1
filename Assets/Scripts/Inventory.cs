using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    public Weapons[] weapons;
    public Text[] weaponsNameText;
    public Text[] weaponsDescriptionText;
    public Image[] weaponsSprites;

    public Armors[] armors;
    public Text[] armorsNameText;
    public Text[] armorsDescriptionText;
    public Image[] armorsSprites;

    private void Awake() {
        if(Instance == null)
        {
            Instance = this;
            
        }else
        {
            Destroy(this);
        }
    }

    public void AddWeapon(Weapons item) {
        {
            for(int i = 0; i < weapons.Length; i++)
            {
                if(weapons[i] == null)
                {
                    weapons[i] = item;
                    weaponsNameText[i].text = item.weaponName;
                    weaponsDescriptionText[i].text = item.weaponDescription;
                    weaponsSprites[i].sprite = item.WeaponSprite;
                    return;
                }
            }
        }
    }

    public void AddArmor(Armors item) {
        {
            for(int i = 0; i < armors.Length; i++)
            {
                if(armors[i] == null)
                {
                    armors[i] = item;
                    armorsNameText[i].text = item.ArmorsName;
                    armorsDescriptionText[i].text = item.ArmorDescription;
                    armorsSprites[i].sprite = item.ArmorSprite;
                    return;
                }
            }
        }
    }
  
}
