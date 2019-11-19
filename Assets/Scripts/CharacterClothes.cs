using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;

public class CharacterClothes : MonoBehaviour
{
    private DynamicCharacterAvatar character;
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<DynamicCharacterAvatar>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClearChest()
    {
        character.ClearSlot("Chest");
        character.BuildCharacter();
    }

    public void ClearLegs()
    {
        character.ClearSlot("Legs");
        character.BuildCharacter();
    }

    public void LongHair()
    {
        character.ClearSlot("Hair");
        character.SetSlot("Hair", "FemaleLongHair_Recipe");
        character.BuildCharacter();
    }

    public void PonyTail()
    {
        character.ClearSlot("Hair");
        character.SetSlot("Hair", "FemalePonyTail_Recipe");
        character.BuildCharacter();
    }

    public void SportPants()
    {
        character.ClearSlot("Legs");
        character.SetSlot("PantsM", "PantsM_Recipe");
        character.BuildCharacter();
    }

    public void TankTop()
    {
        character.ClearSlot("Chest");
        character.SetSlot("Chest", "FemaleTankTop_Recipe");
        character.BuildCharacter();
    }
}
