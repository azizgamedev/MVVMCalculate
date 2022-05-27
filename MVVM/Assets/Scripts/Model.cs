using UnityEngine;
using UnityEngine.Events;

public class Model : MonoBehaviour
{
    [field: SerializeField] private UnityEvent<int> _onSumResult, _onDivisionResult, _onMultiplyResult, _onSubstractResult;

    private void Calculate(int ID, UnityEvent<int> _onResult, int resultCounted)
    {
        if (SignState._isSigned[ID])
        {
            var result = resultCounted;
            _onResult?.Invoke(result);
            SignState boolState = new SignState();
            boolState.DeactivateAllBool();
        }
    }
    public void Count(int firstNumber, int secondNumber)
    {
        Calculate(0, _onSumResult, firstNumber + secondNumber);
        Calculate(1, _onSubstractResult, firstNumber - secondNumber);
        Calculate(2, _onMultiplyResult, firstNumber * secondNumber);
        Calculate(3, _onDivisionResult, firstNumber / secondNumber);
    }
}
