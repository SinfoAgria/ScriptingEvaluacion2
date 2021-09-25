using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalMovement : MonoBehaviour, IMovement
{
    public void Move(float speed)
    {
        transform.Translate(transform.forward * Time.deltaTime * speed  * -1);
    }
}
