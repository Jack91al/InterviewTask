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


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) //Debug use only, delete later
            UpdateClothes();
    }
    
    public void UpdateClothes()
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
