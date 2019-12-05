using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;

public class SelectModel : MonoBehaviour
{
    public int activeModel;
    public DynamicCharacterAvatar avatar0;
    public DynamicCharacterAvatar avatar1;
    public DynamicCharacterAvatar avatar2;
    public DynamicCharacterAvatar character;
    public Transform base0;
    public Transform base1;
    public Transform base2;

    // Start is called before the first frame update
    void Start()
    {
        character = avatar0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeModel ()
    {
        activeModel = (activeModel + 1) % 3;
        if (activeModel == 0)
        {
            character = avatar0;
            avatar0.transform.position = base0.position + new Vector3(0, 0.1f, 0);
            avatar1.transform.position = base1.position + new Vector3(0, 0.1f, 0);
            avatar2.transform.position = base2.position + new Vector3(0, 0.1f, 0);
        }
        if (activeModel == 1)
        {
            character = avatar1;
            avatar0.transform.position = base2.position + new Vector3(0, 0.1f, 0);
            avatar1.transform.position = base0.position + new Vector3(0, 0.1f, 0);
            avatar2.transform.position = base1.position + new Vector3(0, 0.1f, 0);
        }
        if (activeModel == 2)
        {
            character = avatar2;
            avatar0.transform.position = base1.position + new Vector3(0, 0.1f, 0);
            avatar1.transform.position = base2.position + new Vector3(0, 0.1f, 0);
            avatar2.transform.position = base0.position + new Vector3(0, 0.1f, 0);
        }
    }
}
