using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMatchControllerTEST))]
public class PlayerActions : MonoBehaviour {

    // Movement Variables
    public float speed;
    
    // Controls
    [HideInInspector]
    public float VerticalAxisVal;
    [HideInInspector]
    public float HorizontalAxisVal;
    [HideInInspector]
    public bool AttackVal;

    // Finite State Machine
    [HideInInspector]
    public PlayerStates currPlayerState;


    void Start ()
    {
        currPlayerState = PlayerStates.idle;
	}
	
	void FixedUpdate ()
    {
        switch (currPlayerState)
        {
            case PlayerStates.idle:
                ManageMovement();
                break;
            case PlayerStates.attack:
                break;
            case PlayerStates.hitStun:
                break;
            default:
                break;
        }

    }

    void ManageMovement()
    {
        if (VerticalAxisVal != 0f)
        {
            transform.position += transform.up * speed * VerticalAxisVal * Time.deltaTime;
        }

        if (HorizontalAxisVal != 0f)
        {
            transform.position += transform.right * speed * HorizontalAxisVal * Time.deltaTime;
        }

    }

}
