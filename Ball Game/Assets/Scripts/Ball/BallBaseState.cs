using UnityEngine;

public abstract class BallBaseState
{
   public abstract void EnterState(BallStateManager Ball);

   public abstract void UpdateState(BallStateManager Ball);
}
