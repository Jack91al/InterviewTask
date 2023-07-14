using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorePortrait : MonoBehaviour
{
    //This class checks the variables in the "PlayerClothing" class in order to change the sprite of the player character portrait in the store. 
    PlayerClothing playerClothing;
    [SerializeField] private Image frame;
    [SerializeField] private Sprite[] portraits;


    void Start()
    {
        frame = GetComponent<Image>();
        playerClothing = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerClothing>();
    }

    void Update()
    {
        if(playerClothing.special != 1)
        {
            for (int i = 0; i < portraits.Length; i++)
            {
                if(playerClothing.top == i)
                {
                    frame.sprite = portraits[i];
                }
            }            
        }

        else 
            frame.sprite = portraits[portraits.Length - 1];
    }
}
