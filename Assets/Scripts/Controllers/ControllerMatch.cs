using Rewired;
using UnityEngine;

[RequireComponent(typeof(PiggyActions))]
public class ControllerMatch : MonoBehaviour
{
    private Player pl;
    private PiggyActions ActionsComp;

    public void Setup(int _plId)
    {
        pl = ReInput.players.GetPlayer(_plId);
        ActionsComp = GetComponent<PiggyActions>();

        // Add Events
        pl.AddInputEventDelegate(OnMovementPress, UpdateLoopType.Update, InputActionEventType.AxisActive, "HorMov");
    }

    void OnMovementPress(InputActionEventData data)
    {

        ActionsComp.Move(data.GetAxis());

    }

}
