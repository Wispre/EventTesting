using TMPro;
using UnityEngine;

public class StickingParentUI : MonoBehaviour, IObserver
{
    public Sticking sticking;
    public TMP_Text textUI;

    private void OnEnable()
    {
        sticking.AddObserver(this);
    }
    private void OnDisable()
    {
        sticking.RemoveObserver(this);
    }
    public void OnNotify(Collision2D collision)
    {
        textUI.text = $"Parent is: {collision.collider.name}";
    }
}
