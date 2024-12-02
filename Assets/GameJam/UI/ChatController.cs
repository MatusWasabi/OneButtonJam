using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

/// <summary>
/// Responsible for controlling Chat UMXL. Mimicking behavior of chat. 
/// This code is using web dev monolithic-coding approach for one-time rather than component-coding approcahe
/// </summary>
public class ChatController : MonoBehaviour
{
    [SerializeField] private List<SOChat> allChats;
    [SerializeField] private UnityEvent onChatRanOut;
    private ScrollView chatScrollView;
    private VisualElement chatContent;
    private UnityAction onOneChatEnded;
    private int chatIndex;
    private HashSet<VisualElement> chatHistory = new HashSet<VisualElement>();

    private void OnEnable()
    {
        if (chatHistory == null) 
        { 
            return; 
        }

        // Re-Querying is needed as the UI toolkit destroyed references when gameobject is disabled.
        var root = GetComponent<UIDocument>().rootVisualElement;
        chatScrollView = root.Q<ScrollView>("ChatScrollView");
        chatContent = chatScrollView.Q<VisualElement>("ChatContent");

        foreach (var chat in chatHistory)
        {
            chatContent.Add(chat);
        }
        ScrollToBottom();
    }


    private void Start()
    {
        // Access the root element from UIDocument
        var root = GetComponent<UIDocument>().rootVisualElement;

        // Find the ScrollView and its content container
        chatScrollView = root.Q<ScrollView>("ChatScrollView");
        chatScrollView.RegisterCallback<WheelEvent>(evt => evt.StopImmediatePropagation());
        chatContent = chatScrollView.Q<VisualElement>("ChatContent");
        ScrollToBottom();
        InvokeRepeating(nameof(ContinueChat), 1f, 2);
    }

    public void AddChatMessage(SOChat singleChat)
    {
        // Re-Querying is needed as the UI toolkit destroyed references when gameobject is disabled.
        var root = GetComponent<UIDocument>().rootVisualElement;
        chatScrollView = root.Q<ScrollView>("ChatScrollView");
        chatContent = chatScrollView.Q<VisualElement>("ChatContent");

        VisualElement chatRef = singleChat.GetChat();

        // Animate its appearance
        AnimateMessageAppearance(chatRef);

        // Add it to the content container
        chatContent.Add(chatRef);

        
        chatHistory.Add(chatRef);
        
        

        ScrollToBottom();
    }

    private void ContinueChat()
    {
        if (chatIndex >= allChats.Count) 
        {
            onChatRanOut.Invoke();
            CancelInvoke(nameof(ContinueChat));
            return; 
        }
        AddChatMessage(allChats[chatIndex]);
        chatIndex++;
    }

    


    private void AnimateMessageAppearance(VisualElement message)
    {
        // Initial opacity (hidden)
        // message.style.opacity = 0;


        // Delay animation slightly to ensure transition is applied
        message.schedule.Execute(() =>
        {
            message.style.opacity = 1; // Fade in
        }).StartingIn(100); // Delay in milliseconds
    }

    private void ScrollToBottom()
    {
        chatScrollView.verticalScroller.value = chatScrollView.verticalScroller.highValue;
    }

    
}
