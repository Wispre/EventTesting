using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundQueue : MonoBehaviour
{
    public SoundClips clips;
    private AudioSource audioSource;

    private const int MAX_PENDING = 16;
    private PlayMessage[] pending = new PlayMessage[MAX_PENDING];
    private int tail = 0;
    private int head = 0;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(PlayMessage message)
    {
        for(int i = head; i != tail; i = (i + 1) % MAX_PENDING)
        {
            if (pending[i].SoundID == message.SoundID)
            {
                pending[i].Volume = Mathf.Max(message.Volume, pending[i].Volume);
                return;
            }
        }

        if (tail < MAX_PENDING)
        {
            if((tail + 1) % MAX_PENDING != head)
            {
                pending[tail] = new PlayMessage(message.SoundID, message.Volume);
                tail = (tail + 1) % MAX_PENDING;
            }
        }

    }

    private void Update()
    {
        if (head == tail) return;

        if (audioSource.isPlaying) return;

        var index = pending[head].SoundID;

        audioSource.clip = clips.sounds[index];
        audioSource.volume = pending[head].Volume;

        audioSource.Play();

        head = (head + 1) % MAX_PENDING;


    }
}