using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UMA;
using UMA.CharacterSystem;

public class BodyMeasurement : MonoBehaviour
{
    private DynamicCharacterAvatar character;
    public SelectModel selectModel;
    public Dictionary<string, DnaSetter> dna;
    public Text textHeight;
    public Text textBreast;
    public Text textWaist;
    public Text textHip;
    private Text measurement;
    private float intHeight;
    private float intBreast;
    private float intWaist;
    private float intHip;
    public float maxHeight;
    public float minHeight;
    public float maxBreast;
    public float minBreast;
    public float maxWaist;
    public float minWaist;
    public float maxHip;
    public float minHip;
    private string stringValue = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectField(string field)
    {
        if (field == "height")
        {
            measurement = textHeight.GetComponent<Text>();
        }
        else if (field == "breast")
        {
            measurement = textBreast.GetComponent<Text>();
        }
        else if (field == "waist")
        {
            measurement = textWaist.GetComponent<Text>();
        }
        else if (field == "hip")
        {
            measurement = textHip.GetComponent<Text>();
        }
        stringValue = measurement.text;
    }

    public void AddDigit(string digit)
    {
        if (stringValue == "0")
        {
            stringValue = digit;
        }
        else if (stringValue.Length < 3)
        {
            stringValue += digit;
        }

        measurement.text = stringValue;
        UpdateMeasurements();
    }

    public void DelDigit()
    {
        if (stringValue.Length > 0)
        {
            stringValue = stringValue.Substring(0,stringValue.Length - 1);
        }
        if (stringValue.Length == 0)
        {
            stringValue = "0";
        }
        measurement.text = stringValue;
        UpdateMeasurements();
    }

    public void UpdateMeasurements()
    {
        character = selectModel.character;
        intHeight = float.Parse(textHeight.text);
        intBreast = float.Parse(textBreast.text);
        intWaist = float.Parse(textWaist.text);
        intHip = float.Parse(textHip.text);
        if (intHeight > maxHeight)
        {
            intHeight = 1;
        }
        else if (intHeight < minHeight)
        {
            intHeight = 0;
        }
        else
        {
            intHeight = ((intHeight - minHeight) / (maxHeight - minHeight));
        }
        if (intBreast > maxBreast)
        {
            intHeight = 1;
        }
        else if (intBreast < minBreast)
        {
            intBreast = 0;
        }
        else
        {
            intBreast = (intBreast - minBreast) / (maxBreast - minBreast);
        }
        if (intWaist > maxWaist)
        {
            intWaist = 1;
        }
        else if (intWaist < minWaist)
        {
            intWaist = 0;
        }
        else
        {
            intWaist = (intWaist - minWaist) / (maxWaist - minWaist);
        }
        if (intHip > maxHip)
        {
            intHip = 1;
        }
        else if (intHip < minHip)
        {
            intHip = 0;
        }
        else
        {
            intHip = (intHip - minHip) / (maxHip - minHip);
        }
        if (dna == null)
        {
            dna = character.GetDNA();
        }
        dna["height"].Set(intHeight);
        dna["breastSize"].Set(intBreast);
        dna["waist"].Set(intWaist);
        dna["lowerWeight"].Set(intHip);
        character.BuildCharacter();
    }
}
