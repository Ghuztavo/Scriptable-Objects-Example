using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "CardList", menuName = "Scriptable Objects/CardList")]
public class CardList : ScriptableObject
{
    [Tooltip("List of resource paths")]
    public List<string> cardResourcePaths = new List<string>();

    private Dictionary<string, CardData> loadedCards = new Dictionary<string, CardData>();

    public CardData GetCard(int index)
    {
        if (index < 0 || index >= cardResourcePaths.Count)
            return null;

        string path = cardResourcePaths[index];
        
        if (loadedCards.ContainsKey(path))
        {
            return loadedCards[path];
        }
        else
        {
            // Load the card data from the Resources folder matching the path string
            CardData card = Resources.Load<CardData>(path);
            if (card != null)
            {
                loadedCards[path] = card;
            }
            else
            {
                Debug.LogWarning($"Failed to load CardData at resource path: {path}");
            }
            return card;
        }
    }
}
