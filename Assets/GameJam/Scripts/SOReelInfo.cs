
using UnityEngine;
using UnityEngine.Video;

[CreateAssetMenu(menuName = "Game Jam/Reel Info")]
public class SOReelInfo : ScriptableObject
{
    [SerializeField] private Stats givenStats;
    [SerializeField] private VideoClip video;

    public Stats GetStats() => givenStats;
  
    public VideoClip GetVideo() => video;
}
