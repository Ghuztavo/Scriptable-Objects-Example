using UnityEngine;

[CreateAssetMenu(fileName = "CardData", menuName = "Scriptable Objects/CardData")]
public class CardData : ScriptableObject
{
    public string NameLocKey;
    public string DescriptionLocKey;
    public string Type;
    public int Cost;
    public int Att;
    public int Def;
    public Sprite Image;
}
