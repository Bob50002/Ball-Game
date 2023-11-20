using UnityEngine;

public class BallMoveState : BallBaseState
{
    public override void EnterState(BallStateManager Ball)
    {
        Ball._ArrowForward.SetActive(false);

        Ball._ArrowHorizontal.SetActive(true);

        Ball.GetComponent<MeshRenderer>().enabled = true;
    }

    public override void UpdateState(BallStateManager Ball)
    {
     
        if (Input.GetKey(KeyCode.A))
        {
            Ball.transform.Translate(Vector3.left * Ball._Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Ball.transform.Translate(Vector3.right * Ball._Speed * Time.deltaTime);
        }

       if (Input.GetKeyDown(KeyCode.Space))
        {
            Ball.SwitchState(Ball._AimState);
        }
    }
}
