using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class StickingWithAction : MonoBehaviour
{
    public Action<Collision2D> OnGotStuck;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.parent = collision.transform;
        OnGotStuck?.Invoke(collision);
    }
}