using UnityEngine;

public interface IObserver
{
    public void OnNotify(Collision2D collision);
}