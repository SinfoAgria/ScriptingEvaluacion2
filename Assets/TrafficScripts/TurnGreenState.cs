using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnGreenState : ITrafficLightState
{
    public void Execute(TrafficLight tlight)
    {
        tlight.Greenlight.SetActive(true);
        tlight.Yellowlight.SetActive(false);
        tlight.Redlight.SetActive(false);
    }
}
