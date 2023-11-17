using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStateManager : MonoBehaviour
{
    BallBaseState CurrentState;

    public BallShootState _ShootState = new BallShootState();

    public BallMoveState _MoveState = new BallMoveState();

    public GameObject _ArrowHorizontal;

    public GameObject _ArrowForward;

    [HideInInspector]
    public float _DegreeToRotate;
    
    
    [HideInInspector]
    public Rigidbody _RB;

    public float _Speed;

    void Start()
    {
        CurrentState = _MoveState;

        _RB = gameObject.GetComponent<Rigidbody>();

        CurrentState.EnterState(this);
    }

    // Update is called once per frame
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
