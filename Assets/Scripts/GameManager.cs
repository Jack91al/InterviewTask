using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //The Game Manager in this case is used to manage the money counters on the User Interface.

    public static GameManager instance;

    [SerializeField] private TMP_Text[] moneyCounters;

    public int playerMoney;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < moneyCounters.Length; i++)
        {
            moneyCounters[i].text = "" + playerMoney;
        }
    }
}
