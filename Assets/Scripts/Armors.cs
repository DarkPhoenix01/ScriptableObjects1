using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName="Items/Armors", fileName = "New Armor")]
public class Armors : ScriptableObject
{
    public string ArmorsName;
    public string ArmorDescription;
    public Sprite ArmorSprite;
    public float ArmorResistance;
    
}
