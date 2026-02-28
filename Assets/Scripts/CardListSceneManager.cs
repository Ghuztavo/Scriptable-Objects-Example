using UnityEngine;
using UnityEngine.UI;

public class CardListSceneManager : MonoBehaviour
{
    public CardList cardListSO;
    public Theme currentTheme;
    public Language currentLanguage;
    public string currentLangCode = "en";

    [Header("UI References")]
    public Transform scrollViewContent;
    public GameObject cardItemPrefab; 
    public CardDisplayPanel cardDisplayPanel; 

    void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        if (cardListSO == null) return;

        for (int i = 0; i < cardListSO.cardResourcePaths.Count; i++)
        {
            CardData card = cardListSO.GetCard(i);
            if (card == null) continue;

            GameObject newObj = Instantiate(cardItemPrefab, scrollViewContent, false);
            
            newObj.transform.localScale = Vector3.one;
            Image img = newObj.GetComponent<Image>();
            if (img != null && card.Image != null)
            {
                img.sprite = card.Image;
            }
            
            Button btn = newObj.GetComponent<Button>();
            if (btn != null)
            {
                CardData capturedCard = card;
                btn.onClick.AddListener(() => OnCardClicked(capturedCard));
            }
        }
    }

    void OnCardClicked(CardData card)
    {
        if (cardDisplayPanel != null)
        {
            cardDisplayPanel.gameObject.SetActive(true);
            cardDisplayPanel.SetCard(card, currentTheme, currentLanguage, currentLangCode);
        }
    }

    public void CloseCardDisplay()
    {
        if (cardDisplayPanel != null)
        {
            cardDisplayPanel.gameObject.SetActive(false);
        }
    }
}
