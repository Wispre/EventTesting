using UnityEngine;

public class PhysicsObserver : MonoBehaviour
{
    public PhysicsObserver next;

    public void AddObserver(PhysicsObserver observer)
    {
        if(next == null)
        {
            this.next = observer;
        }
        else
        {
            next.AddObserver(observer);
        }
    }
}
