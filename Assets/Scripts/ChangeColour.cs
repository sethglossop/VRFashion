using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UMA;
using UMA.CharacterSystem;

public class ChangeColour : MonoBehaviour
{
    private DynamicCharacterAvatar character;
    public SelectModel selectModel;
    public Dictionary<string, DnaSetter> dna;
    private Color colour;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateColour(string slot)
    {
        character = selectModel.character;
        colour = GetComponent<Image>().color;
        character.SetColor(slot, colour);
        character.UpdateColors(true);
    }
}
