using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Sounds")]
public class SoundClips : ScriptableObject
{
    public List<AudioClip> sounds;
}