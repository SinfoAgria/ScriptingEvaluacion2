using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MovementSelection : MonoBehaviour, IMovement 
    
{
    [SerializeField] private GameObject selectionResponseHolder;
    [SerializeField] private ButtonReader brSO = default;

    private Car car;

    private List<IMovement> selectionResponse;
    private int currentIndex = 0;

    public void Awake() {
        selectionResponse = selectionResponseHolder.GetComponents<IMovement>().ToList();
    }

    public void OnEnable() {
        brSO.reverseEvent += Next;
    }

    public void Next() {
        currentIndex = (currentIndex + 1) % selectionResponse.Count;
    }

    public void Move(Car car) {
        this.car = car;
        selectionResponse[currentIndex].Move(car);
    }
}
