using UnityEngine;

public class BallReleasedState : BallBaseState
{
    
    public override void EnterState(BallStateManager Ball)
    {
        Ball.GetComponent<MeshRenderer>().enabled = false;

        Ball.transform.rotation = Quaternion.identity; //Reset rotation

        Ball.transform.position = new Vector3(Ball._OriginalPositionX, Ball.transform.position.y, Ball.transform.position.z); //Reset position

        Ball._PowerGauge.value = 0;    //Reset power gauge

        Ball._Power = 0; //Reset power 

        Ball._Countdown = Ball._OriginalCountdownValue; //Reset timer
    }
   

    public override void UpdateState(BallStateManager Ball)
    {
        Ball._Countdown -= Time.deltaTime;

        if (Ball._Countdown <= 0)
        {
            Ball.SwitchState(Ball._MoveState);
        } 
    }
}
