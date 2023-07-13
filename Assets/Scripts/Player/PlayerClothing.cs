using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClothing : MonoBehaviour
{
    [SerializeField] private int hat, top, special;
    private int pHat, pTop, pSpecial;

    [SerializeField] private GameObject[] hatSprites = new GameObject[3];
    [SerializeField] private GameObject[] topSprites = new GameObject[3];
    [SerializeField] private GameObject[] specialSprites = new GameObject[2];


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UpdateClothes()
    {
        for (int i = 0; i < hatSprites.Length; i++)
        {
            hatSprites[i].SetActive(false);
        }

        hatSprites[hat].SetActive(true);

        for (int i = 0; i < topSprites.Length; i++)
        {
            hatSprites[i].SetActive(false);
        }

        topSprites[top].SetActive(true);

        for (int i = 0; i < specialSprites.Length; i++)
        {
            hatSprites[i].SetActive(false);
        }

        specialSprites[hat].SetActive(true);
    }
}
