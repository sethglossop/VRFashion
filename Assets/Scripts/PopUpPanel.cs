using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpPanel : MonoBehaviour
{
    public Text panelDescription;
    public Text panelPrice;
    public Image panelPicture;
    public GameObject itemPanel;
    public GameObject cartPanel;
    public int cartNumber = 0;
    public GameObject item1;
    public Text item1Description;
    public Text item1Price;
    public Image item1Picture;
    public GameObject item2;
    public Text item2Description;
    public Text item2Price;
    public Image item2Picture;
    public GameObject item3;
    public Text item3Description;
    public Text item3Price;
    public Image item3Picture;

    public void ShoppingCart()
    {
        itemPanel.SetActive(false);
        cartPanel.SetActive(true);
    }

    public void AddToCart()
    {
        switch (cartNumber)
        {
            case 0:
                item1.SetActive(true);
                item1Description.text = panelDescription.text;
                item1Price.text = panelPrice.text;
                item1Picture.sprite = panelPicture.sprite;
                cartNumber++;
                break;
            case 1:
                item2.SetActive(true);
                item2Description.text = panelDescription.text;
                item2Price.text = panelPrice.text;
                item2Picture.sprite = panelPicture.sprite;
                cartNumber++;
                break;
            case 2:
                item3.SetActive(true);
                item3Description.text = panelDescription.text;
                item3Price.text = panelPrice.text;
                item3Picture.sprite = panelPicture.sprite;
                cartNumber++;
                break;
            default:
                break;
        }
    }

    public void RemoveFromCart(int itemNumber)
    {
        if (itemNumber < 3)
        {
            if (itemNumber < 2)
            {
                item1Description.text = item2Description.text;
                item1Price.text = item2Price.text;
                item1Picture.sprite = item2Picture.sprite;
            }
            item2Description.text = item3Description.text;
            item2Price.text = item3Price.text;
            item2Picture.sprite = item3Picture.sprite;

        }
        switch (cartNumber)
        {
            case 1:
                item1.SetActive(false);
                break;
            case 2:
                item2.SetActive(false);
                break;
            case 3:
                item3.SetActive(false);
                break;
            default:
                break;
        }
        cartNumber--;
    }
}

