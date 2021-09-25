using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Car : MonoBehaviour
{
    [SerializeField] private ButtonReader brSO = default;
    [SerializeField] private float speed;
    
    private ICarState icarState;
    private IMovement imovement;

    public float Speed { get => speed; set => speed = value; }

    void Awake()
    {
        icarState = new AcelerateState();
        icarState.Execute(this);

        imovement = GetComponent<IMovement>();
    }

    private void OnEnable()
    {
        brSO.greenEvent += Acelerate;
        brSO.redEvent += Stop;
        brSO.yellowEvent += SlowSpeed;
    }
    private void OnDisable()
    {
        brSO.greenEvent -= Acelerate;
        brSO.redEvent -= Stop;
        brSO.yellowEvent -= SlowSpeed;
    }
    private void Update()
    {
        imovement.Move(Speed);
    }

    public void Acelerate()
    {
        icarState = new AcelerateState();
        icarState.Execute(this);
    }

    public void SlowSpeed()
    {
        icarState = new SlowSpeedState();
        icarState.Execute(this);
    }
    public void Stop()
    {
        icarState = new StopState();
        icarState.Execute(this);
    }

}
