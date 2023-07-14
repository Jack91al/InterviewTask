using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreTrigger : MonoBehaviour
{
    //This class checks if the player character is close to the shopkeeper in order to interact with them.


    [SerializeField] private GameObject tip, storeUI; //There's a tip included to tell the player what key they need to press in order to open the store menu.
    [SerializeField] private bool canOpenStore;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canOpenStore = true;
            tip.SetActive(true);
        }
            
    }
    private void Update()
    {
        if(canOpenStore && Input.GetKeyDown(KeyCode.E))
        {
            storeUI.SetActive(true);
            tip.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canOpenStore = false;
            tip.SetActive(false);
        }
            
    }


}
