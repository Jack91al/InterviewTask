using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreButtons : MonoBehaviour
{
    StoreManager sm;
    private void Start()
    {
        sm = GetComponent<StoreManager>();
    }

    public void SellButton()
    {
        sm.storeState = StoreManager.StoreWindow.Selling;
    }

    public void ShirtButton()
    {
        sm.storeState = StoreManager.StoreWindow.Shirts;
    }

    public void SpecialButton()
    {
        sm.storeState = StoreManager.StoreWindow.Special;
    }
}
