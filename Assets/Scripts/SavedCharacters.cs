using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;

public class SavedCharacters : MonoBehaviour
{
    private DynamicCharacterAvatar character;
    public string savedCharacter;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<DynamicCharacterAvatar>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveCharacter()
    {
        savedCharacter = character.GetCurrentRecipe();
    }

    public void LoadCharacter()
    {
        character.ClearSlots();
        character.LoadFromRecipeString(savedCharacter);
    }
}
