using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchManager : MonoBehaviour
{

    private eMatchStates currMatchState;

    void OnEnable()
    {
        Setup();
    }

    void Setup()
    {
        currMatchState = eMatchStates.ready;
    }
}
