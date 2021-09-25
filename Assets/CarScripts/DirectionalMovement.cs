using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalMovement : MonoBehaviour, IMovement
{
    public void Move(Car car)
    {
        car.transform.Translate(transform.forward * Time.deltaTime * car.Speed  * -1);
    }
}
