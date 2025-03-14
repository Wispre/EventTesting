using UnityEngine;

public struct PlayMessage
{
    public int SoundID;
    public float Volume;

    public PlayMessage(int id, float volume)
    {
        this.SoundID = id;
        this.Volume = volume;
    }
}