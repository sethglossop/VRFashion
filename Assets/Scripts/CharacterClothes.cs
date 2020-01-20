using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;

public class CharacterClothes : MonoBehaviour
{
    private DynamicCharacterAvatar character;
    public SelectModel selectModel;
    public Dictionary<string, DnaSetter> dna;
    private string currentSlot;
    private string currentRecipe;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetSlot(string slot)
    {
        currentSlot = slot;
    }

    public void SetRecipe(string recipe)
    {
        currentRecipe = recipe;
        UpdateClothes();
    }

    public void UpdateClothes()
    {
        character = selectModel.character;
        character.ClearSlot(currentSlot);
        if (currentRecipe != "Remove")
        {
            character.SetSlot(currentSlot, currentRecipe);
        }
        character.BuildCharacter();
    }

}
