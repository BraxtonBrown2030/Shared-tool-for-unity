using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Vector3SO : ScriptableObject
{

    public Vector3 vector3Value;
    public UnityEvent updateValue, resetValue;

    public void UpdateVector(Vector3 curVector)
    {

        vector3Value = curVector;
        updateValue.Invoke();

    }

    public void ResetVector(Vector3 curVector)
    {

        vector3Value = curVector;
        resetValue.Invoke();

    }

}