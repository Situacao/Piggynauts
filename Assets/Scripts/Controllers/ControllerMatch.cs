using Rewired;
using UnityEngine;

public class ControllerMatch : MonoBehaviour
{
    private Player pl;


    public void Setup(int _plId)
    {
        pl = ReInput.players.GetPlayer(_plId);


        // Add Events
        pl.AddInputEventDelegate(OnMovementPress, UpdateLoopType.Update, InputActionEventType.AxisActive, "HorMov");
    }

    void OnMovementPress(InputActionEventData data)
    {

        print("Hello");

    }

}
