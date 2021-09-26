using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambulance : Car, IAlert
{
    public Ambulance() : base()
    {
       
    }
   

    public override void OnEnable()
    {
        brSO.greenEvent += Acelerate;
    }

    
    public void Alert()
    {
        Debug.Log("Aiudaaaaa");
    }

    public override void PlaySound()
    {
        Debug.Log("iu iu iu");

    }
}