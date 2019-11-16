using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderWeight : MonoBehaviour
{
    private LevelManager levelManager;
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        levelManager.upperWeight = slider.value;
    }
}
