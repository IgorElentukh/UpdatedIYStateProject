using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastRunningState : GroundedState
{
    private readonly FastRunningStateConfig _config;
    public FastRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    => _config = character.Config.FastRunningStateConfig;

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

        if (Input.Movement.FastRunning.ReadValue<float>() == 1)
            return;


            StateSwitcher.SwitchState<RunningState>();
    }
}
