using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public struct LocData 
{
    public string key;
    public string en;
    public string fr;
    public string sp;
}

[CreateAssetMenu(fileName = "Language", menuName = "Scriptable Objects/Language")]
public class Language : ScriptableObject
{
    public List<LocData> locDataList = new List<LocData>();

    public string GetString(string key, string langCode)
    {
        foreach (var data in locDataList)
        {
            if (data.key == key)
            {
                switch(langCode.ToLower())
                {
                    case "en": return data.en;
                    case "fr": return data.fr;
                    case "sp": return data.sp;
                    default: return data.en;
                }
            }
        }
        return $"[MISSING LOC: {key}]";
    }
}
