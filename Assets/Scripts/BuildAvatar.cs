using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;

public class BuildAvatar : MonoBehaviour
{
    private DynamicCharacterAvatar character;
    private Dictionary<string, DnaSetter> dna;

    void Start()
    {
        character = GetComponent<DynamicCharacterAvatar>();
    }

    public void UpdateAvatar(float height, float breast, float waist, float hip)
    {
        if (dna == null)
        {
            dna = character.GetDNA();
        }
        dna["height"].Set(height);
        dna["breastSize"].Set(breast);
        dna["waist"].Set(waist);
        dna["lowerWeight"].Set(hip);
        character.BuildCharacter();
    }
}
