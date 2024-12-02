using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(menuName = "Game Jam/Chat")]
public class SOChat : ScriptableObject
{
    [SerializeField] private VisualTreeAsset chatUMXL;
    [SerializeField] [TextArea] private string text;
    
    // Create and change the text ready to used for controller.
    public VisualElement GetChat()
    {
        VisualElement chat = chatUMXL.CloneTree();
        chat.Q<Label>("ChatText").text = text;
        return chat;
    } 
}
