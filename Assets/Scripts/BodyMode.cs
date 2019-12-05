using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMode : MonoBehaviour
{
    public GameObject measurements;
    public GameObject skinhair;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SkinHair()
    {
        measurements.SetActive(false);
        skinhair.SetActive(true);
    }

    public void Measurements()
    {
        skinhair.SetActive(false);
        measurements.SetActive(true);
    }
}
