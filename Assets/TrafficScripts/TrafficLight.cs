using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    [SerializeField] private ButtonReader brSO = default;

    private ITrafficLightState itrafficlight;

    [SerializeField] private GameObject redlight;
    [SerializeField] private GameObject yellowlight;
    [SerializeField] private GameObject greenlight;

    public GameObject Redlight { get => redlight; set => redlight = value; }
    public GameObject Yellowlight { get => yellowlight; set => yellowlight = value; }
    public GameObject Greenlight { get => greenlight; set => greenlight = value; }

    private void Awake()
    {
        itrafficlight = new TurnGreenState();
        itrafficlight.Execute(this);
    }
    private void OnEnable()
    {
        brSO.greenEvent += TurnGreen;
        brSO.redEvent += TurnRed;
        brSO.yellowEvent += TurnYellow;
    }
    private void OnDisable()
    {
        brSO.greenEvent -= TurnGreen;
        brSO.redEvent -= TurnRed;
        brSO.yellowEvent -= TurnYellow;
    }
   public void TurnRed()
    {
        itrafficlight = new TurnRedState();
        itrafficlight.Execute(this);
    }
    public void TurnYellow()
    {
        itrafficlight = new TurnYellowState();
        itrafficlight.Execute(this);
    }
    public void TurnGreen()
    {
        itrafficlight = new TurnGreenState();
        itrafficlight.Execute(this);
    }
}
