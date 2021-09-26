using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcelerateState : ICarState,ICarSmoke
{
    public void Execute(Car car)
    {
        car.Speed = 10f;
    }

    public void ThrowSmoke()
    {
     Debug.Log("Smoke Smoke");

    }
}
