using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallStateManager : MonoBehaviour
{
    BallBaseState CurrentState;

    public BallShootState _ShootState = new BallShootState();

    public BallMoveState _MoveState = new BallMoveState();

    public BallReleasedState _ReleasedState = new BallReleasedState();



    public GameObject _ArrowHorizontal;

    public GameObject _ArrowForward;

    public Slider _PowerGauge;


    public float _Speed;
    
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
