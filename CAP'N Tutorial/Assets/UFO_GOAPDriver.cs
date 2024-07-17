using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cheese.GOAP;
using Cheese.GOAP.Aircraft;

public class UFO_GOAPDriver : GOAPDriver
{
    public UFOFlightModel ufo;
    public SimpleAircraftSpecs aircraftSpecs;

    public override GOAPWorldState GetCurrentState()
    {
        return new GOAPWorldState_SimpleAircraft(ufo.rb);
    }

    protected override GOAPPathRequest_Vehicle GetRequest()
    {
        return new GOAPPathRequest_SimpleAircraft(this, defaultMoveGoal, stepTime, vehicleSpecs, aircraftSpecs);
    }

    protected override Vector3 GetVelocity()
    {
        return ufo.rb.velocity;
    }

    public override bool IsAlive()
    {
        return true;
    }

    protected override void MoveVelocity(Vector3 velocity)
    {
        ufo.SetTargetVelocity(velocity);
    }

    protected override void TerminalNavigate()
    {
        MoveVelocity(Vector3.zero);
    }

    protected override void Panic()
    {
        MoveVelocity(Vector3.up * 10);
    }
}
