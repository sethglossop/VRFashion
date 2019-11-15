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
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            character.SetSlot("Chest", "MaleHoodie_Recipe");
            character.BuildCharacter();
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            character.ClearSlot("Chest");
            character.BuildCharacter();
        }
    }
}
