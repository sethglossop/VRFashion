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
    private float height = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<DynamicCharacterAvatar>();
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (dna == null)
        //{
        //   dna = character.GetDNA();
        //}

        //dna["height"].Set(levelManager.height);
        //character.BuildCharacter();

        //if(Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    if (dna == null)
        //    {
        //        dna = character.GetDNA();
        //    }

        //    height += 0.1f;
        //    dna["height"].Set(height);
        //    character.BuildCharacter();
        //}

        if (dna == null)
        {
            dna = character.GetDNA();
        }

        dna["height"].Set(levelManager.height);
        character.BuildCharacter();
    }
}
