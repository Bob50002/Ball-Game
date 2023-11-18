using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallStateManager : MonoBehaviour
{
    BallBaseState CurrentState;

    public BallMoveState _MoveState = new BallMoveState();
    public BallShootState _ShootState = new BallShootState();
    public BallAimState _AimState = new BallAimState();
    public BallReleasedState _ReleasedState = new BallReleasedState();
    
    [Header("Arrows")]
    public GameObject _ArrowHorizontal;
    public GameObject _ArrowForward;
    public Slider _PowerGauge;

    [Header("Ball shoot")]
    public float _Speed;
    public float _Power;
    
    [HideInInspector]
    public Rigidbody _RB;

    void Start()
    {
        CurrentState = _MoveState;

        _RB = gameObject.GetComponent<Rigidbody>();

        CurrentState.EnterState(this);
    }

    void Update()
    {
        CurrentState.UpdateState(this);
    }

    public void SwitchState(BallBaseState State)
    {
        CurrentState = State;

        State.EnterState(this);
    }
}
