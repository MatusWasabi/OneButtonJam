using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Getting the ending considering given variable. 
/// </summary>
public class EndingSelector : MonoBehaviour
{
    [SerializeField] private List<SOChat> lazyChats;
    [SerializeField] private List<SOChat> spamChats;
    [SerializeField] private List<SOChat> cringeChats;
    [SerializeField] private List<SOChat> cuteCatChats;
    [SerializeField] private List<SOChat> funnyChats;
    [SerializeField] private List<SOChat> basicChats;
    [SerializeField] private ChatController chatController;
    [SerializeField] private StatsHolder statsHolder;

    private void OnEnable()
    {
        StartCoroutine(GetEnding());
    }

    private IEnumerator GetEnding()
    {

        if (statsHolder.holderStats.VideoAmount <= 4)
        {
            foreach (SOChat chat in lazyChats)
            {
                chatController.AddChatMessage(chat);
            }
            yield break;
        }

        if (statsHolder.holderStats.VideoAmount >= 9)
        {
            foreach (SOChat chat in spamChats)
            {
                chatController.AddChatMessage(chat);
            }
            yield break;
        }



        if (statsHolder.holderStats.Brainrot >= 3)
        {
            foreach (SOChat chat in cringeChats) 
            {
                chatController.AddChatMessage(chat);
            }
            yield break;
        }

        if (statsHolder.holderStats.CuteCat >= 3)
        {
            foreach (SOChat chat in cuteCatChats)
            {
                chatController.AddChatMessage(chat);
            }
            yield break;
        }

        if (statsHolder.holderStats.Funny >= 3)
        {
            foreach (SOChat chat in funnyChats)
            {
                chatController.AddChatMessage(chat);
            }
            yield break;
        }

        foreach(SOChat chat in basicChats)
        {
            chatController.AddChatMessage(chat);
        }

    }
}
