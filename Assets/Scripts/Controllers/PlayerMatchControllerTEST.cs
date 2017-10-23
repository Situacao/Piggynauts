using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NDream.AirConsole;
using Newtonsoft.Json.Linq;

public class PlayerMatchControllerTEST : MonoBehaviour {

    private PlayerActions plAct; 
	private bool directionUp;
	private bool directionDown;
	private bool directionLeft;
	private bool directionRight;

	void Awake ()
    {
		directionUp = false;
		directionDown = false;
		directionRight = false;
		directionLeft = false;

        plAct = GetComponent<PlayerActions>();
		AirConsole.instance.onMessage += OnMessage;
	}
	
	void Update ()
    {
		if (directionUp)
        {
			plAct.VerticalAxisVal = 1f;
        }
		else if (directionDown)
        {
			plAct.VerticalAxisVal = -1f;
        }
        else
        {
            plAct.VerticalAxisVal = 0f;
        }

		if (directionRight)
        {
			plAct.HorizontalAxisVal = 1f;
        }
		else if (directionLeft)
        {
			plAct.HorizontalAxisVal = -1f;
        }
        else
        {
            plAct.HorizontalAxisVal = 0f;
        }
			

    }

	void OnMessage(int from, JToken data) {
		AirConsole.instance.Message(from, "FULL");

		string smash = (string) data["data"]["smash"];
		string key = (string) data["data"]["key"];
		bool pressed = (bool) data["data"]["pressed"];


		if (key == "up" && pressed)
			directionUp = true;
		else
			directionUp = false;

		if (key == "down" && pressed)
			directionDown = true;
		else
			directionDown = false;

		if (key == "left" && pressed)
			directionLeft = true;
		else
			directionLeft = false;

		if (key == "right" && pressed)
			directionRight = true;
		else
			directionRight = false;

		Debug.Log (key + " - " + data); 


		if (!string.IsNullOrEmpty(smash))
			Debug.Log (smash);

	}
		
}
