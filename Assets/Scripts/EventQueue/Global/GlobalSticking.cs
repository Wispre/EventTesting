using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class GlobalSticking : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.parent = collision.transform;

        GlobalEvents.OnGotStuck?.Invoke(collision);
    }
}
