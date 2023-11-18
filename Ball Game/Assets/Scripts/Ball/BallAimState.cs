using UnityEngine;

public class BallAimState : BallBaseState
{
    private Vector3 FromPoint = new Vector3(0.0F, 45.0F, 0.0F);

    private Vector3 ToPoint = new Vector3(0.0F, -45.0F, 0.0F);

    private float RotateSpeed = 1.0F;
    public override void EnterState(BallStateManager Ball)
    {
        Ball._ArrowForward.SetActive(true);

        Ball._ArrowHorizontal.SetActive(false);
    }


    public override void UpdateState(BallStateManager Ball)
    {
        Quaternion From = Quaternion.Euler(FromPoint);

        Quaternion To = Quaternion.Euler(ToPoint);

        float lerp = 0.5F * (1.0F + Mathf.Sin(Mathf.PI * Time.time * RotateSpeed));

        Ball.transform.localRotation = Quaternion.Lerp(From, To, lerp);   //Spin


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ball.SwitchState(Ball._ShootState);
        }
    }
}
