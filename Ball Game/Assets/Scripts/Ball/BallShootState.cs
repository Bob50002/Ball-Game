using UnityEngine;

public class BallShootState : BallBaseState
{
    
    private bool PowerDecay;

    public override void EnterState(BallStateManager Ball)
    {
        PowerDecay = false;
    }

    public override void UpdateState(BallStateManager Ball)
    {
        Ball._PowerGauge.value = Ball._Power;

        if (PowerDecay == false)
        {
            Ball._Power += 10 * Time.deltaTime;

            if (Ball._Power >= Ball._MaxPower)          //Power increase
            {
                PowerDecay = true;
            }
        }
       
        if (PowerDecay == true)
        {
            Ball._Power -= 10 * Time.deltaTime;

            if (Ball._Power <= 0)
            {
                PowerDecay = false;                     //Power decrease
            }
        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ball._ArrowForward.SetActive(false);     //Disable arrow
         
            GameObject NewBall = GameObject.Instantiate(Ball._BallPrefab, Ball._BallPosition);  //Instantiate new ball

            Rigidbody RB = NewBall.GetComponent<Rigidbody>(); //Get rigidbody

            RB.velocity = (NewBall.transform.forward * Ball._Power);   //Add power to ball

            NewBall.transform.parent = Ball._BallPrefabDump.transform;

            Ball.SwitchState(Ball._ReleasedState);  //Switch state

        }
    }
}
