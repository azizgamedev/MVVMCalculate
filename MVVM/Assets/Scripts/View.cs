using System.Linq;
using TMPro;
using UnityEngine;

public class View : MonoBehaviour
{
    [field: SerializeField] private TMP_InputField _inputField;

    public void UpdateInputFieldValue(int result)
    {
        _inputField.text += $"{result}";
    }

    public void AddCountButtons(string value)
    {
        if (SignState._isSigned.All(c => c == false))
        {
            _inputField.text += value;
        }
    }

    public void ResetInputField()
    {
        _inputField.text = null;
    }
}
