using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject UIObject;
    [SerializeField] GameObject Ball;
    [SerializeField] GameObject PlaceholderBall;
    [SerializeField] GameObject StartBoost;
    public void clickedStart()
    {
        UIObject.SetActive(false);
        Ball.SetActive(true);
        PlaceholderBall.SetActive(false);
        StartBoost.SetActive(true);
    }
}
