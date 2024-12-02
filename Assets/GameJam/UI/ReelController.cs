using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;
using UnityEngine.Video;

/// <summary>
/// Controlling video player as similar behavior to reel.
/// </summary>
public class ReelController : MonoBehaviour
{
    [SerializeField] private List<SOReelInfo> reelInfos;
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private UnityEvent onClipRanOut;
    [SerializeField] private StatsHolder statsHolder;
    [SerializeField] private UnityEvent onControllerEnable;
    [SerializeField] private UnityEvent onControllerDisable;
    [SerializeField] private Sprite defaultSprite;
    [SerializeField] private Sprite lovedSprite;

    private int clipsIndex;

    private void OnEnable()
    {
        onControllerEnable.Invoke();
    }

    private void OnDisable()
    {
        onControllerDisable.Invoke();
    }


    private void Start()
    {
        videoPlayer.clip = reelInfos[clipsIndex].GetVideo();
    }

    private void NextClip()
    {
        clipsIndex++;
        
        if (clipsIndex >= reelInfos.Count)
        {
            onClipRanOut.Invoke();
            return;
        }

        videoPlayer.clip = reelInfos[clipsIndex].GetVideo();
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        root.Q("Heart").style.backgroundImage = new Background { sprite = defaultSprite };
    }

    public void ShareVideo(bool isVideoShared)
    {
        if (isVideoShared)
        {
            StartCoroutine(Feedback());
            statsHolder.Sum(reelInfos[clipsIndex].GetStats());
            return;
        }

        NextClip();
    }

    private IEnumerator Feedback()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        root.Q<Label>("Shared").visible = true;
        yield return new WaitForSeconds(1);
        root.Q<Label>("Shared").visible = false;
        root.Q("Heart").style.backgroundImage = new Background { sprite = lovedSprite };

    }
}
