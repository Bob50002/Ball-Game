using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] GameObject NewBallPrefab;

    [SerializeField] Transform BallPosition;

    private Transform SpawnPosition;

    private void Start()
    {
        SpawnPosition = BallPosition;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnBall();
        }
    }
    void SpawnBall()
    {
        Instantiate(NewBallPrefab, SpawnPosition);

        Debug.Log("Spawn");
    }
}
