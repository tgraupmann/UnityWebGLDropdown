using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetOptions : MonoBehaviour
{
    public Dropdown _mDropDown = null;

    Dropdown.OptionData CreateOptionData(string text)
    {
        Dropdown.OptionData data = new Dropdown.OptionData();
        data.text = text;
        return data;
    }

    // Use this for initialization
    void Start()
    {
        if (_mDropDown)
        {
            List<Dropdown.OptionData> options = new List<Dropdown.OptionData>();
            options.Add(CreateOptionData("Languages"));
            options.Add(CreateOptionData("Something else"));
            _mDropDown.ClearOptions();
            _mDropDown.AddOptions(options);
        }
    }
}
