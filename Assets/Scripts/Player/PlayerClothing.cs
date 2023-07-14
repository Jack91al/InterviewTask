using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClothing : MonoBehaviour
{
    public static PlayerClothing instance; 

    PlayerMovement playerMovement;
    public int top, special;
    private int pTop, pSpecial;

    [SerializeField] private GameObject[] topSprites = new GameObject[4];
    [SerializeField] private GameObject[] specialSprites = new GameObject[2];


    void Start()
    {
        instance = this;
        playerMovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {

    }
    
    public void UpdateClothes() //Checks the "Top" and "Special" variables on this class to change the player's character clothes. 
    {
        for (int i = 0; i < topSprites.Length; i++)
        {
            topSprites[i].SetActive(false);
        }

        if(top != 0)
        {
            topSprites[top].SetActive(true);
            playerMovement.animCurrentClothes = topSprites[top].GetComponent<Animator>();
        }       

        for (int i = 0; i < specialSprites.Length; i++)
        {
            specialSprites[i].SetActive(false);
        }

        if(special != 0)
        {
            if(top != 0)
                topSprites[top].SetActive(false);

            specialSprites[special].SetActive(true);
            playerMovement.animCurrentClothes = specialSprites[special].GetComponent<Animator>();
            
        }

        playerMovement.ResetAnim();
    }
}
