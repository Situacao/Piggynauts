using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NDream.AirConsole;
using Newtonsoft.Json.Linq;

public class PlayerMatchController : MonoBehaviour {

    private PlayerActions plAct;

	void Awake ()
    {

        plAct = GetComponent<PlayerActions>();
		AirConsole.instance.onMessage += OnMessage;
	}
	
	void OnMessage(int from, JToken data)
    {

        AirConsole.instance.Message(from, "FULL");

		string smash = (string) data["data"]["smash"];
		string key = (string) data["data"]["key"];
		bool pressed = (bool) data["data"]["pressed"];

        // Movement
        if (pressed)
        {
            if (key == "up")
            {
                plAct.VerticalAxisVal = 1f;
            }
            else if (key == "down")
            {
                plAct.VerticalAxisVal = -1f;
            }

            if (key == "left")
            {
                plAct.HorizontalAxisVal = -1f;
            }
            else if (key == "right")
            {
                plAct.HorizontalAxisVal = 1f;
            }
        }
        else
        {
            plAct.VerticalAxisVal = 0f;
            plAct.HorizontalAxisVal = 0f;
        }

        // Attack
        if (!string.IsNullOrEmpty(smash))
        {
            Debug.Log(smash);
            plAct.AttackVal = true;
        }
        else
        {
            plAct.AttackVal = false;
        }

        //Debug.Log(key + " - " + data);


    }

}
