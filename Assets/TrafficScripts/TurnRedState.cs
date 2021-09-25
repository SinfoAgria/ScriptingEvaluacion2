using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRedState : ITrafficLightState
{
    public void Execute(TrafficLight tlight)
    {
        tlight.Redlight.SetActive(true);
        tlight.Greenlight.SetActive(false);
        tlight.Yellowlight.SetActive(false);
    }
}