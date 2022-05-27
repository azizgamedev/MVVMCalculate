using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ViewModel : MonoBehaviour
{
    [field: SerializeField] private TMP_InputField _inputField;
    [field: SerializeField] private List<int> sNumbers;
    [field: SerializeField] private UnityEvent<int, int> _onEquals;
    [field: SerializeField] private UnityEvent _onClearField;

    public void SplitLine()
    {
        var numbers = _inputField.text.Split('+', '-', '/', '*').Select(Int32.Parse);
        sNumbers.Add(numbers.Max());
        sNumbers.Add(numbers.Min());
       _onClearField?.Invoke();
       _onEquals?.Invoke(sNumbers[0], sNumbers[1]);
        sNumbers.Clear();
    }

}
