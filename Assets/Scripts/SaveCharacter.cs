using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;

public class SaveCharacter : MonoBehaviour
{
    private DynamicCharacterAvatar character;
    private SavedCharacters savedCharacters;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<DynamicCharacterAvatar>();
        savedCharacters = FindObjectOfType<SavedCharacters>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Save()

    {
    savedCharacters.savedCharacter = character.GetCurrentRecipe();
    }
}


