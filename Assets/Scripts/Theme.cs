using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "Theme", menuName = "Scriptable Objects/Theme")]
public class Theme : ScriptableObject
{
    public TMP_FontAsset RegularFontType;
    public Color RegularFontColor = Color.white;
    public Sprite RegularButtonStyle;
    
    public TMP_FontAsset SpecialFontType;
    public Color SpecialFontColor = Color.yellow;
    public FontStyles SpecialFontStyle = FontStyles.Bold;
}
