using UnityEngine;

public class BallShootState : BallBaseState
{
    private float MaxPower;
    private bool PowerDecay;

    public override void EnterState(BallStateManager Ball)
    {
        MaxPower = Ball._Power * 10;

        PowerDecay = false;

        Ball._PowerGauge.maxValue = MaxPower;
    }

    public override void UpdateState(BallStateManager Ball)
    {
        Ball._PowerGauge.value = Ball._Power;



        if (PowerDecay == false)
        {
            Ball._Power += 10 * Time.deltaTime;

            if (Ball._Power >= MaxPower)
            {
                PowerDecay = true;
            }
        }
       
        if (PowerDecay == true)
        {
            Ball._Power -= 10 * Time.deltaTime;

            if (Ball._Power <= 0)
            {
                PowerDecay = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ball._ArrowForward.SetActive(false);     //Disable arrow

            Ball._PowerGauge.value = 0;    //Reset power

            Ball._RB.velocity = (Ball.transform.forward * Ball._Power); //Add power to ball

            Ball.SwitchState(Ball._ReleasedState);  //Switch state


        }


    }
}
