using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMatchControllerTEST : MonoBehaviour {

    private PlayerActions plAct; 

	void Awake ()
    {
        plAct = GetComponent<PlayerActions>();
	}
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            plAct.VerticalAxisVal = 1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            plAct.VerticalAxisVal = -1f;
        }
        else
        {
            plAct.VerticalAxisVal = 0f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            plAct.HorizontalAxisVal = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            plAct.HorizontalAxisVal = -1f;
        }
        else
        {
            plAct.HorizontalAxisVal = 0f;
        }

    }
}
