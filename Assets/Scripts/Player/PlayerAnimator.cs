using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles interactions with the animator component of the player
/// It reads the player's state from the controller and animates accordingly
/// </summary>
public class PlayerAnimator : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("The player controller script to read state information from")]
    public PlayerController playerController;
    [Tooltip("The animator component that controls the player's animations")]
    public Animator animator;

    /// <summary>
    /// Description:
    /// Standard Unity function called once before the first update
    /// Input:
    /// none
    /// Return:
    /// void (no return)
    /// </summary>
    void Start()
    {
        ReadPlayerStateAndAnimate();
    }

    /// <summary>
    /// Description:
    /// Standard Unity function called every frame
    /// Input:
    /// none
    /// Return:
    /// void (no return)
    /// </summary>
    void Update()
    {
        ReadPlayerStateAndAnimate();
    }

    /// <summary>
    /// Description:
    /// Reads the player's state and then sets and unsets booleans in the animator accordingly
    /// Input:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    void ReadPlayerStateAndAnimate()
    {
        if (animator == null)
        {
            return;
        }
        switch (playerController.state)
        {
            case PlayerController.PlayerState.Attack:
                animator.Play("Player_Attack");
                break;
            case PlayerController.PlayerState.Idle:
                animator.Play("Player_Idle");
                break;
            case PlayerController.PlayerState.Walk:
                animator.Play("Player_walk");
                break;
            case PlayerController.PlayerState.Run:
                animator.Play("Player_running");
                break;
            case PlayerController.PlayerState.Jump:
                animator.Play("Player_jumping");
                break;
            case PlayerController.PlayerState.Highjump:
                animator.Play("Player_highjump");
                break;
            case PlayerController.PlayerState.Falling:
                animator.Play("Falling");
                break;
            case PlayerController.PlayerState.Hurt:
                animator.Play("Player_hurt");
                break;
            case PlayerController.PlayerState.Dead:
                animator.Play("Player_death");
                break;
        }
    }
}
