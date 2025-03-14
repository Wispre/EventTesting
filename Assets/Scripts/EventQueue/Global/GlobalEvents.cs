using UnityEngine;
using System;

public static class GlobalEvents
{
    public static Action OnEnemyDied;
    public static Action OnEnemyDiedEnemy;
    public static Action<Color> OnColorChanged;
    public static Action<int> OnNumberChanged;
    public static Action<Collision2D> OnGotStuck;
}