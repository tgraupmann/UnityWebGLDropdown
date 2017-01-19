using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetOptions : MonoBehaviour
{
    public Dropdown _mDropDown = null;

    public TextAsset _mTextAsset = null;

    [Serializable]
    public class LanguageResult
    {
        public Language[] languages;
    }

    [Serializable]
    public class Language
    {
        public string name = string.Empty;
        public Dialect[] dialects;
    }

    [Serializable]
    public class Dialect
    {
        public string name = string.Empty;
        public string description = string.Empty;
    }

    Dropdown.OptionData CreateOptionData(string text)
    {
        Dropdown.OptionData data = new Dropdown.OptionData();
        data.text = text;
        return data;
    }

    // Use this for initialization
    void Start()
    {
        if (_mDropDown &&
            _mTextAsset)
        {
            LanguageResult result = JsonUtility.FromJson<LanguageResult>(_mTextAsset.text);
            List<Dropdown.OptionData> options = new List<Dropdown.OptionData>();
            options.Add(CreateOptionData("Languages"));
            foreach (Language language in result.languages)
            {
                options.Add(CreateOptionData(language.name));
            }
            _mDropDown.ClearOptions();
            _mDropDown.AddOptions(options);
        }
    }
}
