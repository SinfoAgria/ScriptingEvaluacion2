using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName ="ButtonReader", menuName = "Game/ButtonReader")]
public class ButtonReader : ScriptableObject
{
    public event UnityAction redEvent;
    public event UnityAction yellowEvent;
    public event UnityAction greenEvent;

    public void OnRed()
    {
        redEvent?.Invoke();
    }
   
    public void OnYellow()
    {
        yellowEvent?.Invoke();
    }
    public void OnGreen()
    {
        greenEvent?.Invoke();
    }
}
