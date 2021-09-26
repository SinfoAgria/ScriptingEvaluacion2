using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Car : MonoBehaviour, ISound

{
    [SerializeField] protected ButtonReader brSO = default;
    [SerializeField] protected float aceleration;
    protected float speed;


    private ICarState icarState;
    protected IMovement imovement;
    private ISound isound;

    public float Speed { get => speed; set => speed = value; }
    public float Aceleration { get => aceleration; }

    public virtual void Awake() 
    {
        isound = GetComponent<ISound>();
        icarState = new AcelerateState();
        icarState.Execute(this);
        imovement = GetComponent<IMovement>();

    }
    private void Update()
    {
        imovement.Move(this);
        
    }
    public virtual void OnEnable() {
        brSO.greenEvent += Acelerate;
        brSO.redEvent += Stop;
        brSO.yellowEvent += SlowSpeed;
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
    public virtual void PlaySound()
    {
        isound.PlaySound();
    }
}
