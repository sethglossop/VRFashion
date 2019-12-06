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
    public float maxHeight;
    public float minHeight;
    public float maxBreast;
    public float minBreast;
    public float maxWaist;
    public float minWaist;
    public float maxHip;
    public float minHip;
    public Text textHeight;
    public Text textBreast;
    public Text textWaist;
    public Text textHip;
    private Text measurement;
    private float height;
    private float breast;
    private float waist;
    private float hip;
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
        height = float.Parse(textHeight.text);
        breast = float.Parse(textBreast.text);
        waist = float.Parse(textWaist.text);
        hip = float.Parse(textHip.text);
        if (height > maxHeight)
        {
            height = 1;
        }
        else if (height < minHeight)
        {
            height = 0;
        }
        else
        {
            height = ((height - minHeight) / (maxHeight - minHeight));
        }
        if (breast > maxBreast)
        {
            height = 1;
        }
        else if (breast < minBreast)
        {
            breast = 0;
        }
        else
        {
            breast = (breast - minBreast) / (maxBreast - minBreast);
        }
        if (waist > maxWaist)
        {
            waist = 1;
        }
        else if (waist < minWaist)
        {
            waist = 0;
        }
        else
        {
            waist = (waist - minWaist) / (maxWaist - minWaist);
        }
        if (hip > maxHip)
        {
            hip = 1;
        }
        else if (hip < minHip)
        {
            hip = 0;
        }
        else
        {
            hip = (hip - minHip) / (maxHip - minHip);
        }
        dna = character.GetDNA();
        dna["height"].Set(height);
        dna["breastSize"].Set(breast);
        dna["waist"].Set(waist);
        dna["lowerWeight"].Set(hip);
        character.BuildCharacter();
    }
}
