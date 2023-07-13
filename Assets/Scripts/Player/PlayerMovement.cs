using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    #region Variables

    [Header("Base Variables")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private Animator animPlayer;
    public Animator animCurrentClothes;
    private bool isFacingLeft;
    [SerializeField] private bool canMove;

    Rigidbody2D rb;
    private Vector2 moveDir;

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animPlayer = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementStates();
    }

    private void FixedUpdate()
    {
        Movement();
        Flip();
    }

    #region Functions

    void MovementStates() //Allows to change Animations using the "playerAction" variable.
    {
        if (moveDir != Vector2.zero)
            PlayerStates.instance.playerAction = PlayerStates.PlayerAction.Walking;

        else
            PlayerStates.instance.playerAction = PlayerStates.PlayerAction.Idle;

        switch (PlayerStates.instance.playerAction)
        {
            case PlayerStates.PlayerAction.Idle:
                animPlayer.SetBool("Walking", false);
                animCurrentClothes.SetBool("Walking", false);
                break;

            case PlayerStates.PlayerAction.Walking:
                animPlayer.SetBool("Walking", true);
                animCurrentClothes.SetBool("Walking", true);
                break;

            case PlayerStates.PlayerAction.Talking:
                animPlayer.SetBool("Walking", false);
                animCurrentClothes.SetBool("Walking", false);
                break;
        }
    }

    void Movement()
    {
        if(canMove)
        {
            moveDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

            rb.velocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
        }        
    }

    void Flip()
    {
        switch (moveDir.x)
        {
            case < 0:
                isFacingLeft = true;
                break;

            case > 0:
                isFacingLeft = false;
                break;
        }

        if (isFacingLeft)
            transform.localScale = new Vector3(-1, 1, 1);

        else
            transform.localScale = new Vector3(1, 1, 1);
    }

    public void ResetAnim()
    {
        animPlayer.Play("PlayerIdle", -1, 0.0f);
        animPlayer.SetBool("Walking", true);
        animCurrentClothes.SetBool("Walking", true);
    }

    #endregion
}
