using UnityEngine;

public class BallReleasedState : BallBaseState
{
    [SerializeField] GameObject NewBallPrefab;

    public override void EnterState(BallStateManager Ball)
    {
   
    }
   

    public override void UpdateState(BallStateManager Ball)
    {
        if (Ball._RB.velocity.magnitude == 0)
        {
            //Instantiate(NewBallPrefab, 
        }
    }
}
