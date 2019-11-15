using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderHeight : MonoBehaviour
{
    private LevelManager levelManager;
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        slider = GetComponent<Slider>();
        slider.value = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        levelManager.height = slider.value;
    }
}
