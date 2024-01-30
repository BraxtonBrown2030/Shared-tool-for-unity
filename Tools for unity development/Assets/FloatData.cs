using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single Varable / FloatData")]
public class FloatData :ScriptableObject
{
    public float numberFloat;
    public float value;

    public void UpdateFloatVaule(float number)
    {

        numberFloat += number;

    }

    public void ReplaceFloatVaule(float number)
    {

        numberFloat = number;

    }
}
