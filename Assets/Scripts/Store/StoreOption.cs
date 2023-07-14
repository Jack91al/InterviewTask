using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoreOption : MonoBehaviour
{
    //This script determines the properties such as price for the items in the store and control what happens when you click on them.

    #region Variables 

    Button button;
    [SerializeField] private int price, shirtIndex, specialIndex; 
    [SerializeField] private TMP_Text priceText;

    [SerializeField] private bool bought, isSelling;

    #endregion

    void Start()
    {
        button = GetComponent<Button>();
    }

    void Update() 
    {
        if (isSelling) //Determines if the player can buy the item depending on how much money they have.
        {
            if (button.enabled)
                priceText.text = "" + price;

            else
                priceText.text = "Sold!";
        }

        if (price > GameManager.instance.playerMoney && !isSelling)
            button.interactable = false;
        else
            button.interactable = true;

    }

    public void PressOption()
    {
        if(isSelling)
        {
            GameManager.instance.playerMoney += price;
            GetComponent<Button>().enabled = false;
        }

        else
        {
            if(bought)
            {
                PlayerClothing.instance.top = shirtIndex;
                PlayerClothing.instance.special = specialIndex;
                PlayerClothing.instance.UpdateClothes();
            }

            else
            {
                PlayerClothing.instance.top = shirtIndex;
                PlayerClothing.instance.special = specialIndex;
                GameManager.instance.playerMoney -= price;

                PlayerClothing.instance.UpdateClothes();
                Destroy(gameObject);
            }

            
            
        }
    }

}
