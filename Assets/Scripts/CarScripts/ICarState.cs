using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICarState
{
    void Execute(Car car);
}
