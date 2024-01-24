using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single Varable / IntData")]
public class IntData : ScriptableObject
{
    
    public int intData;

    public void UpadteInt(int number)
    {

        intData += number;

    }
    
    public void ReplaceIntVaule(int number)
    {

        intData = number;

    }


}
