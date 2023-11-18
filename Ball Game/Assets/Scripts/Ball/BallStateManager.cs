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
    
    [Header("Indicators")]
    public GameObject _ArrowHorizontal;
    public GameObject _ArrowForward;
    public Slider _PowerGauge;

    [HideInInspector]
    public float _MaxPower;
    [HideInInspector]
    public float _OriginalCountdownValue;

    [Header("Ball shoot")]
    public GameObject _BallPrefab;
    public GameObject _BallPrefabDump; //New parent for ball prefab
    public Transform _BallPosition;
    public float _Countdown;
    public float _Speed;
    public float _Power;
    
    


    void Start()
    {
        CurrentState = _MoveState;

        _BallPosition = this.transform;

        _MaxPower = _Power * 10;

        _PowerGauge.maxValue = _MaxPower;

        _OriginalCountdownValue = _Countdown;

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
