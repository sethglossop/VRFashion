using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesMenu : MonoBehaviour
{
    public RectTransform topsPosition;
    public RectTransform bottomsPosition;
    public RectTransform underwearPosition;
    public GameObject topsButtons;
    public GameObject bottomsButtons;
    public GameObject underwearButtons;
    private bool topsOpen;
    private bool bottomsOpen;
    private bool underwearOpen;
    private Vector2 move;

    // Start is called before the first frame update
    void Start()
    {
        move = new Vector2(0, -80);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Menu(string category)
    {
        switch (category)
        {
            case "tops":
                if (topsOpen)
                {
                    topsOpen = false;
                    topsButtons.SetActive(false);
                    bottomsPosition.anchoredPosition -= move;
                    underwearPosition.anchoredPosition -= move;
                }
                else
                {
                    topsOpen = true;
                    bottomsPosition.anchoredPosition += move;
                    underwearPosition.anchoredPosition += move;
                    topsButtons.SetActive(true);
                }
                break;
            case "bottoms":
                if (bottomsOpen)
                {
                    bottomsOpen = false;
                    bottomsButtons.SetActive(false);
                    underwearPosition.anchoredPosition -= move;
                }
                else
                {
                    bottomsOpen = true;
                    underwearPosition.anchoredPosition += move;
                    bottomsButtons.SetActive(true);
                }
                break;
            case "underwear":
                if (underwearOpen)
                {
                    underwearOpen = false;
                    underwearButtons.SetActive(false);
                }
                else
                {
                    underwearOpen = true;
                    underwearButtons.SetActive(true);
                }
                break;
        }
    }
}
