using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITrafficLightState 
{
    void Execute(TrafficLight tlight);
}
