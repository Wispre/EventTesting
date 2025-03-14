using UnityEngine;

public class WallTouchedSound : MonoBehaviour
{
    public SoundQueue soundQueue;

    public int soundID = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        soundQueue.PlaySound(new PlayMessage(soundID, 1));
    }
}
