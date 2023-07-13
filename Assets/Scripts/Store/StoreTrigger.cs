using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreTrigger : MonoBehaviour
{
    [SerializeField] private GameObject tip, storeUI;
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
