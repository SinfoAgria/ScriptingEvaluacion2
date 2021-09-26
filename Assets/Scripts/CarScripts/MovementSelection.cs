using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MovementSelection : MonoBehaviour, IMovement 
    
{
    [SerializeField] private GameObject selectionResponseHolder;
    [SerializeField] private ButtonReader brSO = default;

 

    private List<IMovement> movementResponse;
    private int currentIndex = 0;

    public void Awake() {
        movementResponse = selectionResponseHolder.GetComponents<IMovement>().ToList();
    }

    public void OnEnable() {
        brSO.reverseEvent += Next;
    }

    public void Next() {
        currentIndex = (currentIndex + 1) % movementResponse.Count;
    }

    public void Move(Car car) {
        
        movementResponse[currentIndex].Move(car);
    }
}
