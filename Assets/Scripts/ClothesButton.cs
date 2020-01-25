using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothesButton : MonoBehaviour
{
    public string itemDescription;
    public string itemPrice;
    public Sprite itemPicture;

    void Start()
    {
        itemPicture = GetComponent<Image>().sprite;
    }

    public void PopUpItem(PopUpPanel popUpPanel)
    {
        popUpPanel.cartPanel.SetActive(false);
        popUpPanel.itemPanel.SetActive(true);
        popUpPanel.panelDescription.text = itemDescription;
        popUpPanel.panelPicture.sprite = itemPicture;
        popUpPanel.panelPrice.text = itemPrice;
    }
}
