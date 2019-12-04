using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UMA;
using UMA.CharacterSystem;

public class GoToShow : MonoBehaviour
{
    public DynamicCharacterAvatar avatar0;
    public DynamicCharacterAvatar avatar1;
    public DynamicCharacterAvatar avatar2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveAndGo()
    {
        SavedCharacters.savedCharacter0 = avatar0.GetCurrentRecipe();
        SavedCharacters.savedCharacter1 = avatar1.GetCurrentRecipe();
        SavedCharacters.savedCharacter2 = avatar2.GetCurrentRecipe();
        SceneManager.LoadScene("FashionShow");
    }
}
