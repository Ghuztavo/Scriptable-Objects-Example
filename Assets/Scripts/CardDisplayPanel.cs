using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CardDisplayPanel : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI typeText;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI attText;
    public TextMeshProUGUI defText;
    public Image cardImage;
    public Image backgroundPanel;
    
    public void SetCard(CardData card, Theme theme, Language language, string langCode)
    {
        // Apply Data and Language
        if (nameText != null) nameText.text = language.GetString(card.NameLocKey, langCode);
        if (descriptionText != null) descriptionText.text = language.GetString(card.DescriptionLocKey, langCode);
        if (typeText != null) typeText.text = "Type: " + card.Type;
        if (costText != null) costText.text = "Cost: " + card.Cost.ToString();
        if (attText != null) attText.text = "Attack: " + card.Att.ToString();
        if (defText != null) defText.text = "Defense: " + card.Def.ToString();
        if (cardImage != null) cardImage.sprite = card.Image;

        // Apply Theme
        if (theme != null)
        {
            ApplyThemeToText(nameText, theme.RegularFontType, theme.RegularFontColor, FontStyles.Normal);
            ApplyThemeToText(descriptionText, theme.RegularFontType, theme.RegularFontColor, FontStyles.Normal);
            ApplyThemeToText(typeText, theme.SpecialFontType, theme.SpecialFontColor, theme.SpecialFontStyle);
            ApplyThemeToText(costText, theme.SpecialFontType, theme.SpecialFontColor, theme.SpecialFontStyle);
            ApplyThemeToText(attText, theme.SpecialFontType, theme.SpecialFontColor, theme.SpecialFontStyle);
            ApplyThemeToText(defText, theme.SpecialFontType, theme.SpecialFontColor, theme.SpecialFontStyle);

            if (backgroundPanel != null && theme.RegularButtonStyle != null)
            {
                backgroundPanel.sprite = theme.RegularButtonStyle;
            }
        }
    }

    private void ApplyThemeToText(TextMeshProUGUI txt, TMP_FontAsset font, Color color, FontStyles style)
    {
        if (txt == null) return;
        if (font != null) txt.font = font;
        txt.color = color;
        txt.fontStyle = style;
    }
}
