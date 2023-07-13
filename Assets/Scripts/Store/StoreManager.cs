using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    public enum StoreWindow
    {
        Shirts, Special, Selling
    }

    public StoreWindow storeState;

    [SerializeField] private Button shirtButton, specialButton;
    [SerializeField] private GameObject shirtOptions, specialOptions, sellOptions;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(storeState)
        {
            case StoreWindow.Selling:
                shirtButton.interactable = false;
                specialButton.interactable = false;

                shirtOptions.SetActive(false);
                specialOptions.SetActive(false);
                sellOptions.SetActive(true);
                break;

            case StoreWindow.Shirts:
                shirtButton.interactable = true;
                specialButton.interactable = true;

                shirtOptions.SetActive(true);
                specialOptions.SetActive(false);
                sellOptions.SetActive(false);
                break;

            case StoreWindow.Special:
                shirtButton.interactable = true;
                specialButton.interactable = true;

                shirtOptions.SetActive(false);
                specialOptions.SetActive(true);
                sellOptions.SetActive(false);
                break;
        }
    }
}
