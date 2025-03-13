using TMPro;
using UnityEngine;

public class ActionUI : MonoBehaviour
{
    public StickingWithAction sticking;
    public TMP_Text textUI;

    private void OnEnable()
    {
        sticking.OnGotStuck += OnNotify;
    }
    private void OnDisable()
    {
        sticking.OnGotStuck -= OnNotify;
    }
    public void OnNotify(Collision2D collision)
    {
        textUI.text = $"Parent is: {collision.collider.name}";
    }
}