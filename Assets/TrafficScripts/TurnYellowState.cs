using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnYellowState : ITrafficLightState
{
    public void Execute(TrafficLight tlight)
    {
        tlight.Yellowlight.SetActive(true);
        tlight.Redlight.SetActive(false);
        tlight.Greenlight.SetActive(false);
    }
}