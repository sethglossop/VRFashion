using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothesButton : MonoBehaviour
{
    public string itemDescription;
    public string itemPrice;
    public Sprite itemPicture;

    // Start is called before the first frame update
    void Start()
    {
        itemPicture = GetComponent<Image>().sprite;
    }

    // Update is called once per frame
    void Update()
    {

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
