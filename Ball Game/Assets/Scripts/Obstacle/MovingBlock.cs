using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    [SerializeField] float Speed;

    [SerializeField] float MaxDistance;

    private float MinDistance;


    private void Start()
    {
        MinDistance = -MaxDistance;
    }
    private void Update()
    {
        if (transform.position.x >= MaxDistance)
        {
            Speed = Speed * -1;
        }
        else if (transform.position.x <= MinDistance)
        {
            Speed = Speed * -1;
        }

        transform.Translate(Speed * Time.deltaTime, 0, 0);  
    }
}
