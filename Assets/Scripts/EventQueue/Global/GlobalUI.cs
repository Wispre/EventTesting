using TMPro;
using UnityEngine;

public class GlobalUI : MonoBehaviour
{
    public TMP_Text textUI;

    private void OnEnable()
    {
        GlobalEvents.OnGotStuck += OnNotify;
    }
    private void OnDisable()
    {
        GlobalEvents.OnGotStuck -= OnNotify;
    }
    public void OnNotify(Collision2D collision)
    {
        textUI.text = $"Parent is: {collision.collider.name}";
    }
}
