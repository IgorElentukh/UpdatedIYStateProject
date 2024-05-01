using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingState : GroundedState
{
    private readonly WalkingStateConfig _config;

    public WalkingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    => _config = character.Config.WalkingStateConfig;

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.Speed;

        View.StartRunning();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopRunning();
    }

    public override void Update()
    {
        base.Update();

        if (Input.Movement.Walking.ReadValue<float>() == 1)
            return;
        
            StateSwitcher.SwitchState<RunningState>();
    }
}
