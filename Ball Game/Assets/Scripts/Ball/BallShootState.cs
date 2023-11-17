using UnityEngine;

public class BallShootState : BallBaseState
{
    private Vector3 m_from = new Vector3(0.0F, 45.0F, 0.0F);

    private Vector3 m_to = new Vector3(0.0F, -45.0F, 0.0F);

    private float RotateSpeed = 1.0F;

    private float Power = 100;

    public override void EnterState(BallStateManager Ball)
    {
        Debug.Log("Shoot now");

        Ball._ArrowForward.SetActive(true);

        Ball._ArrowHorizontal.SetActive(false);
    }

    public override void UpdateState(BallStateManager Ball)
    {
        Quaternion From = Quaternion.Euler(this.m_from);
        Quaternion To = Quaternion.Euler(this.m_to);

        float lerp = 0.5F * (1.0F + Mathf.Sin(Mathf.PI * Time.realtimeSinceStartup * this.RotateSpeed)); 
        Ball.transform.localRotation = Quaternion.Lerp(From, To, lerp);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ball._RB.AddForce(Ball.transform.forward * Power);
        }
    }
}
