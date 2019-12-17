using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TouchpadControl : MonoBehaviour
{
    private SteamVR_ActionSet actionSet;
    private SteamVR_Action_Boolean touchpadPress;
    private SteamVR_Action_Vector2 touchpadPosition;
    private SteamVR_Input_Sources rightHand;
    public GameObject controller;
    private int state = 0;

    // Start is called before the first frame update
    void Start()
    {
        touchpadPress = SteamVR_Actions._default.TouchPadPress;
        touchpadPosition = SteamVR_Actions._default.TouchPadPosition;
        rightHand = SteamVR_Input_Sources.RightHand;
    }

    // Update is called once per frame
    void Update()
    {
        if (touchpadPress.GetStateDown(rightHand))
        {
            Vector2 touchpadValue = touchpadPosition.GetAxis(rightHand);
            float x = touchpadValue.x;
            float y = touchpadValue.y;
            if (Mathf.Abs(x) < 0.5 && Mathf.Abs(y) < 0.5)
            {
                print("center");
            }
            else if (y > x && y > -x)
            {
                print("north");
            }
            else if (y > x && y < -x)
            {
                print("west");
            }
            else if (y < x && y > -x)
            {
                print("east");
            }
            else if (y < x && y < -x)
            {
                print("south");
            }
        }

        
    }
}
