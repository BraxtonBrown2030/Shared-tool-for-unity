using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single Varable / FloatData")]
public class FloatData :ScriptableObject
{
    public float numberFloat;

    public void UpdateFloatVaule(float number)
    {

        numberfloat += number;

    }

    public void ReplaceFloatVaule(flaot number)
    {

        numberfloat = number;

    }
}
