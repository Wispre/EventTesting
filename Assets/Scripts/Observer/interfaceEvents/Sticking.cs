using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Sticking : MonoBehaviour
{
    private List<IObserver> observers = new();
    public void AddObserver(IObserver self)
    {
        observers.Add(self);
    }

    public void RemoveObserver(IObserver self)
    {
        observers.Remove(self);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.parent = collision.transform;

        Notify(collision);
    }

    private void Notify(Collision2D collision)
    {
        for(int i = 0; i < observers.Count; i++)
        {
            observers[i].OnNotify(collision);
        }
    }
}