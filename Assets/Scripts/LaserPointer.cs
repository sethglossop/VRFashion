using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

public class LaserPointer : MonoBehaviour
{
    private SteamVR_LaserPointer laserPointer;

    void Start()
    {
        laserPointer = GetComponent<SteamVR_LaserPointer>();
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        Button b = e.target.gameObject.GetComponent<Button>();
        if (b != null)
        {
            b.onClick.Invoke();
        }
    }
}
