using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStateManager : MonoBehaviour
{
    BallBaseState CurrentState;

    BallShootState ShootState = new BallShootState();

    BallMoveState MoveState = new BallMoveState();


    void Start()
    {
        CurrentState = MoveState;

        CurrentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentState.Cha
    }
}
