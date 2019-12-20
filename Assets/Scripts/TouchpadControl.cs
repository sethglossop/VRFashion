using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class TouchpadControl : MonoBehaviour
{
    private SteamVR_ActionSet actionSet;
    private SteamVR_Action_Boolean touchpadPress;
    private SteamVR_Action_Vector2 touchpadPosition;
    private SteamVR_Input_Sources rightHand;
    public GameObject controller;
    public Transform pointer;
    public GameObject optionsMenu;
    public GameObject sceneMenu;
    public GameObject walkMenu;
    public GameObject envCatwalk;
    public GameObject envForest;
    public GameObject envCity;
    public GameObject envBeach;
    private GameObject envCurrent;
    private string button;
    private string menu = "none";
    public bool pause = false;
    public int style = 4;

    // Start is called before the first frame update
    void Start()
    {
        touchpadPress = SteamVR_Actions._default.TouchPadPress;
        touchpadPosition = SteamVR_Actions._default.TouchPadPosition;
        rightHand = SteamVR_Input_Sources.RightHand;
        envCurrent = envCatwalk;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 touchpadValue = touchpadPosition.GetAxis(rightHand);
        float x = touchpadValue.x;
        float y = touchpadValue.y;
        pointer.transform.localPosition = new Vector3(x * 0.4f, 1, y * 0.4f);

        if (touchpadPress.GetStateDown(rightHand))
        {
            if (Mathf.Abs(x) < 0.5 && Mathf.Abs(y) < 0.5)
            {
                button = "centre";
            }
            else if (y > x && y > -x)
            {
                button = "north";
            }
            else if (y < x && y > -x)
            {
                button = "east";
            }
            else if (y > x && y < -x)
            {
                button = "west";
            }
            else if (y < x && y < -x)
            {
                button = "south";
            }

            switch (menu)
            {
                case "none":
                    controller.SetActive(true);
                    optionsMenu.SetActive(true);
                    menu = "options";
                    break;
                case "options":
                    switch (button)
                    {
                        case "centre":
                            optionsMenu.SetActive(false);
                            controller.SetActive(false);
                            menu = "none";
                            break;
                        case "north":
                            pause = !pause;
                            break;
                        case "east":
                            optionsMenu.SetActive(false);
                            walkMenu.SetActive(true);
                            menu = "walk";
                            break;
                        case "west":
                            optionsMenu.SetActive(false);
                            sceneMenu.SetActive(true);
                            menu = "scene";
                            break;
                        case "south":
                            SceneManager.LoadScene("DressingRoom");
                            break;
                    }
                    break;
                case "walk":
                    switch (button)
                    {
                        case "centre":
                            walkMenu.SetActive(false);
                            optionsMenu.SetActive(true);
                            menu = "options";
                            break;
                        case "north":
                            style = 1;
                            break;
                        case "east":
                            style = 2;
                            break;
                        case "west":
                            style = 3;
                            break;
                        case "south":
                            style = 4;
                            break;
                    }
                    break;
                case "scene":
                    switch (button)
                    {
                        case "centre":
                            sceneMenu.SetActive(false);
                            optionsMenu.SetActive(true);
                            menu = "options";
                            break;
                        case "north":
                            envCurrent.SetActive(false);
                            envCurrent = envCatwalk;
                            envCurrent.SetActive(true);
                            break;
                        case "east":
                            envCurrent.SetActive(false);
                            envCurrent = envBeach;
                            envCurrent.SetActive(true);
                            break;
                        case "west":
                            envCurrent.SetActive(false);
                            envCurrent = envCity;
                            envCurrent.SetActive(true);
                            break;
                        case "south":
                            envCurrent.SetActive(false);
                            envCurrent = envForest;
                            envCurrent.SetActive(true);
                            break;
                    }
                    break;
            }
        }
    }
}
