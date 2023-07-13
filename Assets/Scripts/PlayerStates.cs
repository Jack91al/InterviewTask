using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStates : MonoBehaviour
{
    public static PlayerStates instance;

    [SerializeField] private PlayerCamera playerCamera;
    [SerializeField] private PlayerMovement playerMovement;

    public enum PlayerAction { Idle, Walking, Talking } //The actions that the player can make. These states control the animations and camera of the player.

    public PlayerAction playerAction;

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        
    }

}
