using UnityEngine;

public class BallShootState : BallBaseState
{
    private Vector3 m_from = new Vector3(0.0F, 45.0F, 0.0F);

    private Vector3 m_to = new Vector3(0.0F, -45.0F, 0.0F);

    private float RotateSpeed = 1.0F;

    private float Power = 100;

    private float MaxPower;

    private bool ReadyToShoot;

    public override void EnterState(BallStateManager Ball)
    {
        MaxPower = Power * 10;

        Ball._PowerGauge.maxValue = MaxPower;

        Ball._ArrowForward.SetActive(true);

        Ball._ArrowHorizontal.SetActive(false);
    }

    public override void UpdateState(BallStateManager Ball)
    {
        Quaternion From = Quaternion.Euler(this.m_from);
        Quaternion To = Quaternion.Euler(this.m_to);

        float lerp = 0.5F * (1.0F + Mathf.Sin(Mathf.PI * Time.realtimeSinceStartup * this.RotateSpeed)); 
        Ball.transform.localRotation = Quaternion.Lerp(From, To, lerp);



        if (Input.GetKey(KeyCode.Space))
        {
            Power += 1000 * Time.deltaTime;
        }

        Ball._PowerGauge.value = Power;


        if (Input.GetKeyUp(KeyCode.Space))
        {
            Ball._ArrowForward.SetActive(false);     //Disable arrow

            Ball._RB.AddForce(Ball.transform.forward * Power); //Add power to ball

            Ball.SwitchState(Ball._ReleasedState);  //Switch state
        }


    }
}
