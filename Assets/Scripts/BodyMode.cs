using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMode : MonoBehaviour
{
    public GameObject measurements;
    public GameObject skinhair;
    public GameObject face;
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
        face.SetActive(false);
        measurements.SetActive(false);
        skinhair.SetActive(true);
    }

    public void Measurements()
    {
        face.SetActive(false);
        skinhair.SetActive(false);
        measurements.SetActive(true);
    }

    public void Face()
    {
        skinhair.SetActive(false);
        measurements.SetActive(false);
        face.SetActive(true);
    }
}
