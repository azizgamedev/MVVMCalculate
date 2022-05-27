using UnityEngine;

public class SignState : MonoBehaviour
{
    public static readonly bool[] _isSigned = new bool[4];
    
    public void DeactivateAllBool()
    {
        for (int i = 0; i < _isSigned.Length; i++)
        {
            _isSigned[i] = false;
        }
    }
    private void Awake()
    {
        DeactivateAllBool();
    }

    public void SetState(int index)
    {
        DeactivateAllBool();

        _isSigned[index] = true;
    }
}
