using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public static int _Score;

    [SerializeField] TextMeshProUGUI ScoreCounter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreCounter.text = _Score.ToString();
    }
}
