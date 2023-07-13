using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{   

    [Header("Base Variables")]
    [SerializeField] private float moveSpeed;
    private float baseMoveSpeed;
    [SerializeField] private Animator animPlayer;
    [SerializeField] private SpriteRenderer spritePlayer;
    private bool isFacingLeft;

    Rigidbody2D rb;
    private Vector2 moveDir;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MovementStates() //Allows to change Animations using the "playerAction" variable.
    {
        switch (PlayerStates.instance.playerAction)
        {
            case PlayerStates.PlayerAction.Idle:
                animPlayer.SetBool("Idle", true);
                animPlayer.SetBool("Walking", false);
                animPlayer.SetBool("Idle", false);
                break;

            case PlayerStates.PlayerAction.Walking:
                animPlayer.SetBool("Idle", false);
                animPlayer.SetBool("Walking", true);
                animPlayer.SetBool("Idle", false);
                break;

            case PlayerStates.PlayerAction.Talking:
                animPlayer.SetBool("Idle", false);
                animPlayer.SetBool("Walking", false);
                animPlayer.SetBool("Idle", true);
                break;
        }
    }
}
