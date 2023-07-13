using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorePortrait : MonoBehaviour
{
    PlayerClothing playerClothing;
    [SerializeField] private Image frame;
    [SerializeField] private Sprite[] portraits;


    // Start is called before the first frame update
    void Start()
    {
        frame = GetComponent<Image>();
        playerClothing = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerClothing>();
    }

    // Update is called once per frame
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
