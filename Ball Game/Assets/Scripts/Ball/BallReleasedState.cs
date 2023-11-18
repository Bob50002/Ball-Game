using UnityEngine;

public class BallReleasedState : BallBaseState
{
    

    public override void EnterState(BallStateManager Ball)
    {
        
    }
   

    public override void UpdateState(BallStateManager Ball)
    {
        if (Ball._RB.velocity.magnitude == 0)
        {
            Debug.Log("Stop");

            Ball.GetComponent<BallStateManager>().enabled = false;
        }
    }
}
