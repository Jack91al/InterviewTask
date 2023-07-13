using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerCamera : MonoBehaviour
{
    [Header("Player Cameras")]
    [SerializeField] private CinemachineVirtualCamera defaultCamera;
    [SerializeField] private CinemachineVirtualCamera zoomCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (PlayerStates.instance.playerAction) //Zooms the camera while the player is talking to someone.
        {
            case PlayerStates.PlayerAction.Talking:
                defaultCamera.Priority = 0;
                zoomCamera.Priority = 1;
                break;

            default:
                defaultCamera.Priority = 1;
                zoomCamera.Priority = 0;
                break;
        }
    }
}
