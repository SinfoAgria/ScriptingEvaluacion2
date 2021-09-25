using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StopState : MonoBehaviour, ICarState
{
    public void Execute(Car car)
    {
        car.Speed = 0f;
    }
}
