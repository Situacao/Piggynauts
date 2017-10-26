using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMatchController))]
public class PlayerActions : MonoBehaviour {

    // Movement Variables
    public float MovementSpeed;
    
    // Controls
    [HideInInspector]
    public float VerticalAxisVal;
    [HideInInspector]
    public float HorizontalAxisVal;
    [HideInInspector]
    public bool AttackVal;

    // Components
    private Rigidbody2D rigid;

    // Finite State Machine
    [HideInInspector]
    public ePlayerStates currPlayerState;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();  
    }


    void Start ()
    {
        Setup();

    }
	
	void FixedUpdate ()
    {
        switch (currPlayerState)
        {
            case ePlayerStates.idle:
                ManageMovement();
                if (AttackVal)
                {
                    StartCoroutine(DoAttack());
                }
                break;
            case ePlayerStates.attack:
                break;
            case ePlayerStates.hitStun:
                break;
            default:
                break;
        }

    }

    void Setup()
    {
        // Reset Controller vals
        AttackVal = false;
        HorizontalAxisVal = 0f;
        VerticalAxisVal = 0f;

        currPlayerState = ePlayerStates.idle;
    }


    void ManageMovement()
    {

        if (VerticalAxisVal != 0f)
        {

            rigid.AddForce(transform.up * MovementSpeed * VerticalAxisVal * Time.deltaTime, ForceMode2D.Impulse);
            //transform.position += transform.up * MovementSpeed * VerticalAxisVal * Time.deltaTime;
        }

        if (HorizontalAxisVal != 0f)
        {
            rigid.AddForce(transform.right * MovementSpeed * HorizontalAxisVal * Time.deltaTime, ForceMode2D.Impulse);
            //transform.position += transform.right * MovementSpeed * HorizontalAxisVal * Time.deltaTime;
        }


    }

    IEnumerator DoAttack()
    {
        currPlayerState = ePlayerStates.attack;
        yield return new WaitForSeconds(1.5f);
        currPlayerState = ePlayerStates.idle;

    }

}
