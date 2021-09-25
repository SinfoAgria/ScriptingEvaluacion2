using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CompositeSlecition : MonoBehaviour, IMovement
{
    [SerializeField] private GameObject selectionResponseHolder;

    private Car car;

    private List<IMovement> selectionResponse;
    private int currentIndex = 0;

    public void Awake() {
        selectionResponse = selectionResponseHolder.GetComponents<IMovement>().ToList();
    }

    [ContextMenu("Next")]
    public void Next() {
        selectionResponse[currentIndex].Move(car);
        currentIndex = (currentIndex + 1) % selectionResponse.Count;
    }

    public void Move(Car car) {
        this.car = car;
        selectionResponse[currentIndex].Move(car);
    }
}
