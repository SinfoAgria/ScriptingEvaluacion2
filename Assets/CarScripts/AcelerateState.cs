using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcelerateState : ICarState
{
    public void Execute(Car car)
    {
        car.Speed = 10f;
    }
}
