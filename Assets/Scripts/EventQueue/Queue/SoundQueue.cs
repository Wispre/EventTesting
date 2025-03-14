using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundQueue : MonoBehaviour
{
    public SoundClips clips;
    private AudioSource audioSource;

    private const int MAX_PENDING = 16;
    private PlayMessage[] pending = new PlayMessage[MAX_PENDING];
    private int numPending = 0;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(PlayMessage message)
    {
        if (numPending < MAX_PENDING)
        {
            pending[numPending] = new PlayMessage(message.SoundID, message.Volume);
            numPending++;
        }
    }

    private void Update()
    {
        if (numPending <= 0) return;

        if (audioSource.isPlaying) return;

        var index = pending[0].SoundID;

        audioSource.clip = clips.sounds[index];
        audioSource.volume = pending[0].Volume;

        audioSource.Play();
        numPending--;
    }
}