using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoreOption : MonoBehaviour
{
    Button button;
    [SerializeField] private int price, shirtIndex, specialIndex;
    [SerializeField] private TMP_Text priceText;

    [SerializeField] private bool bought, isSelling;


    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isSelling)
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
