using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single Varable / BoolData")]
public class BoolData : ScriptableObject
{
    public bool boolData;

    public void UpdateVauleOn(bool On)
    {

        boolData = true;

    }

    public void UpdateVauleOff(bool off)
    {

        boolData = false;

    }

}