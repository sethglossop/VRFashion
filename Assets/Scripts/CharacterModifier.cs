using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;

public class CharacterModifier : MonoBehaviour
{
    private DynamicCharacterAvatar character;
    private Dictionary<string, DnaSetter> dna;
    private LevelManager levelManager;
    private float height;
    private float upperWeight;
    private float breastSize;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<DynamicCharacterAvatar>();
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeHeight()
    {
        if (dna == null)
        {
            dna = character.GetDNA();
        }
        height = levelManager.height;
        dna["height"].Set(height);
        character.BuildCharacter();
    }

    public void ChangeWeight()
    {
        if (dna == null)
        {
            dna = character.GetDNA();
        }
        upperWeight = levelManager.upperWeight;
        dna["upperWeight"].Set(upperWeight);
        character.BuildCharacter();
    }

    public void ChangeBreast()
    {
        if (dna == null)
        {
            dna = character.GetDNA();
        }
        breastSize = levelManager.breastSize;
        dna["breastSize"].Set(breastSize);
        character.BuildCharacter();
    }
}